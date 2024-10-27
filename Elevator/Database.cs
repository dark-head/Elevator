using System.Data.SQLite;
using System.Data;
using System.Data.Common;
using System;

namespace Elevator
{
    internal class Database
    {

        private string GetConnectionString()
        {
            string databaseFile = "Elevator.db";
            string connectionString = $"Data Source={databaseFile};Version=3;";
            return connectionString;
        }

        public DataTable SelectAll()
        {
            string connectionString = GetConnectionString();
            string sql = "SELECT * FROM elevator_log ORDER BY id DESC LIMIT 17";
            SQLiteDataAdapter adapter = null;
            DataTable table = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        adapter = new SQLiteDataAdapter(command);
                        table = new DataTable();
                        adapter.Fill(table);
                        conn.Close();
                        return table;

                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }


        }

        public void Insert(string task, DateTime time)
        {
            string connectionString = GetConnectionString();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string selectSql = "SELECT * FROM elevator_log";

                // Create a data adapter to execute the select query and fetch data
                using (SQLiteDataAdapter selectAdapter = new SQLiteDataAdapter(selectSql, conn))
                {
                    // Create a command builder to automatically generate insert, update, and delete commands
                    using (SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(selectAdapter))
                    {
                        // Create a DataSet to store the data
                        using (DataSet dataSet = new DataSet())
                        {
                            try
                            {
                                // Fill the DataSet with data from the "elevator_log" table
                                selectAdapter.Fill(dataSet, "elevator_log");

                                // Get the DataTable containing the "elevator_log" data
                                DataTable dataTable = dataSet.Tables["elevator_log"];

                                // Create a new row to insert into the DataTable
                                DataRow newRow = dataTable.NewRow();

                                // Set the "task" and "time" column in the new row with the provided task parameter
                                newRow["task"] = task;
                                newRow["time"] = time.ToString("yyyy-MM-dd HH:mm:ss");

                                dataTable.Rows.Add(newRow);

                                // Update the database with the changes made to the DataSet
                                selectAdapter.Update(dataSet, "elevator_log");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                        }
                    }
                }

                // Close the database connection when done
                conn.Close();
            }
        }
    }
}
