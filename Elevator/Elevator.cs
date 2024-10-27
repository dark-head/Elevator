using System.Data;

namespace Elevator
{
    public partial class Elevator : Form
    {
        private Database database = new Database();
        DateTime currentDateTime = DateTime.Now;

        public Elevator()
        {
            InitializeComponent();
            panelIndicator();
        }

        static int i = 1;
        static int j = 1;
        public static int groundFloor = 1;
        public static int firstFloor = 23;
        public static int secondFloor = 32;
        static bool isclose = true;
        static bool isGroundFloor = true;
        static bool isFirstFloor = false;
        static bool isSecondFloor = false;
        static bool isElevatorMoving = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();

        }

        private void panelIndicator()
        {
            if (isGroundFloor)
            {
                groundfloorindicator.Image = Properties.Resources.zero;
                firstfloorindicator.Image = Properties.Resources.zero;
                controlpanelindicator.Image = Properties.Resources.zero;
            }
            else if (isFirstFloor)
            {
                groundfloorindicator.Image = Properties.Resources.one;
                firstfloorindicator.Image = Properties.Resources.one;
                controlpanelindicator.Image = Properties.Resources.one;
            }
            else if (isSecondFloor)
            {
                groundfloorindicator.Image = Properties.Resources.two;
                firstfloorindicator.Image = Properties.Resources.two;
                controlpanelindicator.Image = Properties.Resources.two;
            }
        }

        private async void open_door_Tick(object sender, EventArgs e)
        {
            if (i <= 12)
            {
                isclose = false;
                pictureBox1.Left -= i;
                pictureBox2.Left += i;
                i++;
            }
            else
            {
                database.Insert("Door Open", currentDateTime);
                LoadDataIntoDataGridView();
                open_door.Stop();

                await Task.Delay(3000);
                if (!isclose && !isElevatorMoving) { close_door.Start(); }
                await Task.Delay(1000);
                ground_floor.Enabled = true;
                first_floor.Enabled = true;
                clear_log.Enabled = true;
                C_0.Enabled = true;
                C_1.Enabled = true;
            }

        }

        private void Clear_Log_button_Click(object sender, EventArgs e)
        {
            elevator_log.DataSource = null;
        }

        private void LoadDataIntoDataGridView()
        {

            DataTable table = null;
            try
            {
                table = new Database().SelectAll();

                elevator_log.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void close_door_Tick(object sender, EventArgs e)
        {
            if (i >= 1)
            {
                isclose = false;
                i--;
                pictureBox1.Left += i;
                pictureBox2.Left -= i;
                if (i == 1) { isclose = true; }
            }
            else
            {
                database.Insert("Door Close", currentDateTime);
                LoadDataIntoDataGridView();
                close_door.Stop();
            }
        }

        private async void ground_floor_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                first_floor.BackColor = Color.White;
                C_1.BackColor = Color.White;
                ground_floor.BackColor = Color.Red;
                C_0.BackColor = Color.Red;
                ground_floor.Enabled = false;
                first_floor.Enabled = false;
                clear_log.Enabled = false;
                C_1.Enabled = false;
                await Task.Delay(2000);
                if (isclose && !isElevatorMoving)
                {
                    second_floor_timer.Stop();
                    first_floor_timer.Stop();
                    ground_floor_timer.Start();
                }
                else
                {
                    if (isclose)
                    {
                        open_door.Stop();
                        close_door.Start();
                    }
                    afterdoorcloseingroundfloor.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void first_floor_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                ground_floor.BackColor = Color.White;
                C_0.BackColor = Color.White;
                first_floor.BackColor = Color.Red;
                C_1.BackColor = Color.Red;
                ground_floor.Enabled = false;
                first_floor.Enabled = false;
                clear_log.Enabled = false;
                C_0.Enabled = false;
                await Task.Delay(2000);
                if (isclose && !isElevatorMoving)
                {
                    ground_floor_timer.Stop();
                    second_floor_timer.Stop();
                    first_floor_timer.Start();
                }
                else
                {
                    if (isclose)
                    {
                        open_door.Stop();
                        close_door.Start();
                    }
                    afterdoorclose.Start();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void ground_floor_timer_Tick_1(object sender, EventArgs e)
        {
            isGroundFloor = true;
            isFirstFloor = false;
            isSecondFloor = false;
            panelIndicator();

            if (j > groundFloor)
            {

                isElevatorMoving = true;
                j--;
                pictureBox1.Top += j;
                pictureBox2.Top += j;
                pictureBox3.Top += j;
                if (j == 1) { isElevatorMoving = false; ground_floor.BackColor = Color.White; C_0.BackColor = Color.White; }

            }
            else
            {
                ground_floor_timer.Stop();
                database.Insert("Reached Ground Floor", currentDateTime);
                LoadDataIntoDataGridView();
            }

            if (j == groundFloor)
            {
                open_door.Start();
                ground_floor.BackColor = Color.White; C_0.BackColor = Color.White;
            }
        }

        private void first_floor_Tick(object sender, EventArgs e)
        {
            isFirstFloor = true;
            isGroundFloor = false;
            isSecondFloor = false;
            panelIndicator();

            if (j < firstFloor)
            {
                isElevatorMoving = true;
                pictureBox1.Top -= j;
                pictureBox2.Top -= j;
                pictureBox3.Top -= j;
                j++;
                if (j == 23) { isElevatorMoving = false; first_floor.BackColor = Color.White; C_1.BackColor = Color.White; }

            }
            else if (j > firstFloor)
            {
                isElevatorMoving = true;
                j--;
                pictureBox1.Top += j;
                pictureBox2.Top += j;
                pictureBox3.Top += j;
                if (j == 23) { isElevatorMoving = false; first_floor.BackColor = Color.White; C_1.BackColor = Color.White; }

            }
            else
            {
                first_floor_timer.Stop();
                database.Insert("Reached First Floor", currentDateTime);
                LoadDataIntoDataGridView();

            }
            if (j == firstFloor)
            {
                open_door.Start();
                first_floor.BackColor = Color.White; C_1.BackColor = Color.White;
            }

        }

        private void afterdoorclose_Tick_1(object sender, EventArgs e)
        {
            second_floor_timer.Stop();
            ground_floor_timer.Stop();
            first_floor_timer.Start();
            afterdoorclose.Stop();
        }

        private void afterdoorcloseingroundfloor_Tick_1(object sender, EventArgs e)
        {
            first_floor_timer.Stop();
            second_floor_timer.Stop();
            ground_floor_timer.Start();
            afterdoorcloseingroundfloor.Stop();
        }

    }
}

