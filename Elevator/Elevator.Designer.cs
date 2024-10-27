namespace Elevator
{
    partial class Elevator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            g_right_door = new PictureBox();
            g_left_door = new PictureBox();
            f_left_door = new PictureBox();
            f_right_door = new PictureBox();
            s_left_door = new PictureBox();
            s_right_door = new PictureBox();
            ground_floor = new Button();
            first_floor = new Button();
            open_door = new System.Windows.Forms.Timer(components);
            clear_log = new Button();
            close_door = new System.Windows.Forms.Timer(components);
            first_floor_timer = new System.Windows.Forms.Timer(components);
            second_floor_timer = new System.Windows.Forms.Timer(components);
            afterdoorclose = new System.Windows.Forms.Timer(components);
            afterdoorcloseinsecondfloor = new System.Windows.Forms.Timer(components);
            ground_floor_timer = new System.Windows.Forms.Timer(components);
            elevator_log = new DataGridView();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            Heading = new Label();
            C_0 = new Button();
            C_1 = new Button();
            afterdoorcloseingroundfloor = new System.Windows.Forms.Timer(components);
            groundfloorindicator = new PictureBox();
            firstfloorindicator = new PictureBox();
            controlpanelindicator = new PictureBox();
            elevator_panel = new PictureBox();
            log = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)g_right_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)g_left_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)f_left_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)f_right_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)s_left_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)s_right_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevator_log).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groundfloorindicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstfloorindicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controlpanelindicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevator_panel).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.door;
            pictureBox1.Image = Properties.Resources.woodendoor;
            pictureBox1.Location = new Point(0, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.door;
            pictureBox2.Image = Properties.Resources.woodendoor;
            pictureBox2.Location = new Point(90, 253);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(g_right_door);
            panel1.Controls.Add(g_left_door);
            panel1.Controls.Add(f_left_door);
            panel1.Controls.Add(f_right_door);
            panel1.Controls.Add(s_left_door);
            panel1.Controls.Add(s_right_door);
            panel1.Location = new Point(1086, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 411);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IMG_0334;
            pictureBox3.Location = new Point(0, 253);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(180, 156);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // g_right_door
            // 
            g_right_door.BackgroundImage = Properties.Resources.door;
            g_right_door.Image = Properties.Resources.woodendoor;
            g_right_door.Location = new Point(88, 253);
            g_right_door.Name = "g_right_door";
            g_right_door.Size = new Size(90, 156);
            g_right_door.SizeMode = PictureBoxSizeMode.StretchImage;
            g_right_door.TabIndex = 38;
            g_right_door.TabStop = false;
            // 
            // g_left_door
            // 
            g_left_door.BackgroundImage = Properties.Resources.door;
            g_left_door.Image = Properties.Resources.woodendoor;
            g_left_door.Location = new Point(-2, 253);
            g_left_door.Name = "g_left_door";
            g_left_door.Size = new Size(90, 156);
            g_left_door.SizeMode = PictureBoxSizeMode.StretchImage;
            g_left_door.TabIndex = 37;
            g_left_door.TabStop = false;
            // 
            // f_left_door
            // 
            f_left_door.BackgroundImage = Properties.Resources.door;
            f_left_door.Image = Properties.Resources.woodendoor;
            f_left_door.Location = new Point(-1, 0);
            f_left_door.Name = "f_left_door";
            f_left_door.Size = new Size(90, 156);
            f_left_door.SizeMode = PictureBoxSizeMode.StretchImage;
            f_left_door.TabIndex = 39;
            f_left_door.TabStop = false;
            // 
            // f_right_door
            // 
            f_right_door.BackgroundImage = Properties.Resources.door;
            f_right_door.Image = Properties.Resources.woodendoor;
            f_right_door.Location = new Point(89, 0);
            f_right_door.Name = "f_right_door";
            f_right_door.Size = new Size(90, 156);
            f_right_door.SizeMode = PictureBoxSizeMode.StretchImage;
            f_right_door.TabIndex = 40;
            f_right_door.TabStop = false;
            // 
            // s_left_door
            // 
            s_left_door.Location = new Point(0, 0);
            s_left_door.Name = "s_left_door";
            s_left_door.Size = new Size(100, 50);
            s_left_door.TabIndex = 41;
            s_left_door.TabStop = false;
            // 
            // s_right_door
            // 
            s_right_door.Location = new Point(0, 0);
            s_right_door.Name = "s_right_door";
            s_right_door.Size = new Size(100, 50);
            s_right_door.TabIndex = 42;
            s_right_door.TabStop = false;
            // 
            // ground_floor
            // 
            ground_floor.Location = new Point(698, 462);
            ground_floor.Name = "ground_floor";
            ground_floor.Size = new Size(46, 39);
            ground_floor.TabIndex = 4;
            ground_floor.Text = "0";
            ground_floor.UseVisualStyleBackColor = true;
            ground_floor.Click += ground_floor_ClickAsync;
            // 
            // first_floor
            // 
            first_floor.Location = new Point(777, 462);
            first_floor.Name = "first_floor";
            first_floor.Size = new Size(46, 39);
            first_floor.TabIndex = 5;
            first_floor.Text = "1";
            first_floor.UseVisualStyleBackColor = true;
            first_floor.Click += first_floor_ClickAsync;
            // 
            // open_door
            // 
            open_door.Interval = 150;
            open_door.Tick += open_door_Tick;
            // 
            // clear_log
            // 
            clear_log.Location = new Point(445, 196);
            clear_log.Name = "clear_log";
            clear_log.Size = new Size(68, 39);
            clear_log.TabIndex = 7;
            clear_log.Text = "Clear";
            clear_log.UseVisualStyleBackColor = true;
            clear_log.Click += Clear_Log_button_Click;
            // 
            // close_door
            // 
            close_door.Interval = 150;
            close_door.Tick += close_door_Tick;
            // 
            // first_floor_timer
            // 
            first_floor_timer.Interval = 150;
            first_floor_timer.Tick += first_floor_Tick;
            // 
            // afterdoorclose
            // 
            afterdoorclose.Interval = 2000;
            afterdoorclose.Tick += afterdoorclose_Tick_1;
            // 
            // ground_floor_timer
            // 
            ground_floor_timer.Interval = 150;
            ground_floor_timer.Tick += ground_floor_timer_Tick_1;
            // 
            // elevator_log
            // 
            elevator_log.AllowUserToAddRows = false;
            elevator_log.AllowUserToDeleteRows = false;
            elevator_log.AllowUserToOrderColumns = true;
            elevator_log.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            elevator_log.Location = new Point(59, 196);
            elevator_log.Name = "elevator_log";
            elevator_log.ReadOnly = true;
            elevator_log.RowTemplate.Height = 25;
            elevator_log.Size = new Size(344, 432);
            elevator_log.TabIndex = 18;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.wall;
            pictureBox15.Location = new Point(926, 420);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(500, 156);
            pictureBox15.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox15.TabIndex = 19;
            pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Properties.Resources.walkpath;
            pictureBox16.Location = new Point(926, 576);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(500, 70);
            pictureBox16.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox16.TabIndex = 20;
            pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = SystemColors.AppWorkspace;
            pictureBox17.Location = new Point(926, 646);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(500, 27);
            pictureBox17.TabIndex = 21;
            pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.BackColor = SystemColors.AppWorkspace;
            pictureBox18.Location = new Point(926, 393);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(500, 27);
            pictureBox18.TabIndex = 24;
            pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.Image = Properties.Resources.walkpath;
            pictureBox19.Location = new Point(926, 323);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(500, 70);
            pictureBox19.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox19.TabIndex = 23;
            pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            pictureBox20.Image = Properties.Resources.wall;
            pictureBox20.Location = new Point(926, 167);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(500, 156);
            pictureBox20.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox20.TabIndex = 22;
            pictureBox20.TabStop = false;
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Heading.Location = new Point(987, 39);
            Heading.Name = "Heading";
            Heading.Size = new Size(402, 50);
            Heading.TabIndex = 28;
            Heading.Text = "!! ELEVATOR HOUSE !!";
            // 
            // C_0
            // 
            C_0.BackgroundImageLayout = ImageLayout.Stretch;
            C_0.Location = new Point(1331, 489);
            C_0.Name = "C_0";
            C_0.Size = new Size(32, 23);
            C_0.TabIndex = 29;
            C_0.Text = "C";
            C_0.UseVisualStyleBackColor = true;
            C_0.Click += ground_floor_ClickAsync;
            // 
            // C_1
            // 
            C_1.BackgroundImageLayout = ImageLayout.Stretch;
            C_1.Location = new Point(1336, 238);
            C_1.Name = "C_1";
            C_1.Size = new Size(30, 23);
            C_1.TabIndex = 30;
            C_1.Text = "C";
            C_1.UseVisualStyleBackColor = true;
            C_1.Click += first_floor_ClickAsync;
            // 
            // afterdoorcloseingroundfloor
            // 
            afterdoorcloseingroundfloor.Interval = 2000;
            afterdoorcloseingroundfloor.Tick += afterdoorcloseingroundfloor_Tick_1;
            // 
            // groundfloorindicator
            // 
            groundfloorindicator.Location = new Point(1322, 443);
            groundfloorindicator.Name = "groundfloorindicator";
            groundfloorindicator.Size = new Size(52, 40);
            groundfloorindicator.SizeMode = PictureBoxSizeMode.StretchImage;
            groundfloorindicator.TabIndex = 32;
            groundfloorindicator.TabStop = false;
            // 
            // firstfloorindicator
            // 
            firstfloorindicator.Location = new Point(1322, 192);
            firstfloorindicator.Name = "firstfloorindicator";
            firstfloorindicator.Size = new Size(52, 40);
            firstfloorindicator.SizeMode = PictureBoxSizeMode.StretchImage;
            firstfloorindicator.TabIndex = 33;
            firstfloorindicator.TabStop = false;
            // 
            // controlpanelindicator
            // 
            controlpanelindicator.Location = new Point(733, 363);
            controlpanelindicator.Name = "controlpanelindicator";
            controlpanelindicator.Size = new Size(52, 40);
            controlpanelindicator.SizeMode = PictureBoxSizeMode.StretchImage;
            controlpanelindicator.TabIndex = 35;
            controlpanelindicator.TabStop = false;
            // 
            // elevator_panel
            // 
            elevator_panel.Image = Properties.Resources.elevator_control_panel_img;
            elevator_panel.Location = new Point(679, 347);
            elevator_panel.Name = "elevator_panel";
            elevator_panel.Size = new Size(161, 228);
            elevator_panel.SizeMode = PictureBoxSizeMode.StretchImage;
            elevator_panel.TabIndex = 36;
            elevator_panel.TabStop = false;
            // 
            // log
            // 
            log.AutoSize = true;
            log.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            log.Location = new Point(198, 126);
            log.Name = "log";
            log.Size = new Size(81, 47);
            log.TabIndex = 37;
            log.Text = "Log";
            // 
            // Elevator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1518, 941);
            Controls.Add(log);
            Controls.Add(controlpanelindicator);
            Controls.Add(firstfloorindicator);
            Controls.Add(groundfloorindicator);
            Controls.Add(C_1);
            Controls.Add(C_0);
            Controls.Add(Heading);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox16);
            Controls.Add(elevator_log);
            Controls.Add(panel1);
            Controls.Add(clear_log);
            Controls.Add(first_floor);
            Controls.Add(ground_floor);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox15);
            Controls.Add(elevator_panel);
            Name = "Elevator";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)g_right_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)g_left_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)f_left_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)f_right_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)s_left_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)s_right_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevator_log).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)groundfloorindicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstfloorindicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)controlpanelindicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevator_panel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button ground_floor;
        private Button first_floor;
        private System.Windows.Forms.Timer open_door;
        private Button clear_log;
        private System.Windows.Forms.Timer close_door;
        private System.Windows.Forms.Timer first_floor_timer;
        private System.Windows.Forms.Timer second_floor_timer;
        private System.Windows.Forms.Timer afterdoorclose;
        private System.Windows.Forms.Timer afterdoorcloseinsecondfloor;
        private System.Windows.Forms.Timer ground_floor_timer;
        private DataGridView elevator_log;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private Label Heading;
        private Button C_0;
        private Button C_1;
        private System.Windows.Forms.Timer afterdoorcloseingroundfloor;
        private PictureBox groundfloorindicator;
        private PictureBox firstfloorindicator;
        private PictureBox controlpanelindicator;
        private PictureBox pictureBox3;
        private PictureBox g_left_door;
        private PictureBox g_right_door;
        private PictureBox f_left_door;
        private PictureBox f_right_door;
        private PictureBox s_left_door;
        private PictureBox s_right_door;
        private PictureBox elevator_panel;
        private Label log;
    }
}