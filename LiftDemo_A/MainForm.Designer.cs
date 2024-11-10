namespace ElevatorProject
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonAlarm;


        /// <summary>
        /// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.liftTimerUp = new System.Windows.Forms.Timer(this.components);
            this.doorTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.liftTimerDown = new System.Windows.Forms.Timer(this.components);
            this.doorRight_1 = new System.Windows.Forms.PictureBox();
            this.doorLeft_1 = new System.Windows.Forms.PictureBox();
            this.doorRight_G = new System.Windows.Forms.PictureBox();
            this.doorLeft_G = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_G = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.liftPanel = new System.Windows.Forms.PictureBox();
            this.mainElevator = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).BeginInit();
            this.SuspendLayout();
            // 
            // liftTimerUp
            // 
            this.liftTimerUp.Interval = 50;
            this.liftTimerUp.Tick += new System.EventHandler(this.liftTimerUp_Tick);
            // 
            // doorTimer
            // 
            this.doorTimer.Tick += new System.EventHandler(this.door_Timer_Tick);
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(691, 89);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.RowHeadersWidth = 51;
            this.dataGridViewLogs.RowTemplate.Height = 24;
            this.dataGridViewLogs.Size = new System.Drawing.Size(426, 344);
            this.dataGridViewLogs.TabIndex = 10;
            // 
            // liftTimerDown
            // 
            this.liftTimerDown.Tick += new System.EventHandler(this.liftTimerDown_Tick);
            // 
            // doorRight_1
            // 
            this.doorRight_1.BackgroundImage = global::LiftDemo_A.Properties.Resources.lift_door_right;
            this.doorRight_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRight_1.Location = new System.Drawing.Point(174, 0);
            this.doorRight_1.Name = "doorRight_1";
            this.doorRight_1.Size = new System.Drawing.Size(81, 208);
            this.doorRight_1.TabIndex = 9;
            this.doorRight_1.TabStop = false;
            // 
            // doorLeft_1
            // 
            this.doorLeft_1.BackgroundImage = global::LiftDemo_A.Properties.Resources.lift_door_left;
            this.doorLeft_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeft_1.Location = new System.Drawing.Point(93, 0);
            this.doorLeft_1.Name = "doorLeft_1";
            this.doorLeft_1.Size = new System.Drawing.Size(83, 208);
            this.doorLeft_1.TabIndex = 8;
            this.doorLeft_1.TabStop = false;
            // 
            // doorRight_G
            // 
            this.doorRight_G.BackgroundImage = global::LiftDemo_A.Properties.Resources.lift_door_right;
            this.doorRight_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRight_G.Location = new System.Drawing.Point(174, 356);
            this.doorRight_G.Name = "doorRight_G";
            this.doorRight_G.Size = new System.Drawing.Size(81, 208);
            this.doorRight_G.TabIndex = 7;
            this.doorRight_G.TabStop = false;
            // 
            // doorLeft_G
            // 
            this.doorLeft_G.BackgroundImage = global::LiftDemo_A.Properties.Resources.lift_door_left;
            this.doorLeft_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeft_G.Location = new System.Drawing.Point(93, 356);
            this.doorLeft_G.Name = "doorLeft_G";
            this.doorLeft_G.Size = new System.Drawing.Size(83, 208);
            this.doorLeft_G.TabIndex = 6;
            this.doorLeft_G.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(513, 257);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(80, 77);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Open.BackgroundImage")));
            this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Open.Location = new System.Drawing.Point(409, 257);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(80, 77);
            this.btn_Open.TabIndex = 4;
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_G
            // 
            this.btn_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_G.BackgroundImage")));
            this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_G.Location = new System.Drawing.Point(460, 158);
            this.btn_G.Name = "btn_G";
            this.btn_G.Size = new System.Drawing.Size(80, 77);
            this.btn_G.TabIndex = 3;
            this.btn_G.UseVisualStyleBackColor = true;
            this.btn_G.Click += new System.EventHandler(this.btn_G_click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Transparent;
            this.btn_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_1.BackgroundImage")));
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_1.Location = new System.Drawing.Point(460, 65);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(80, 77);
            this.btn_1.TabIndex = 2;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_click);
            // 
            // liftPanel
            // 
            this.liftPanel.BackgroundImage = global::LiftDemo_A.Properties.Resources.panel;
            this.liftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.liftPanel.Location = new System.Drawing.Point(389, 0);
            this.liftPanel.Name = "liftPanel";
            this.liftPanel.Size = new System.Drawing.Size(218, 537);
            this.liftPanel.TabIndex = 1;
            this.liftPanel.TabStop = false;
            // 
            // mainElevator
            // 
            this.mainElevator.BackgroundImage = global::LiftDemo_A.Properties.Resources.lift_transparent;
            this.mainElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainElevator.Location = new System.Drawing.Point(93, 356);
            this.mainElevator.Name = "mainElevator";
            this.mainElevator.Size = new System.Drawing.Size(162, 208);
            this.mainElevator.TabIndex = 0;
            this.mainElevator.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(279, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_G_click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(279, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 30);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_1_click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(279, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_G_click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(279, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 30);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_1_click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(460, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 77);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonAlarm_Click);
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.Location = new System.Drawing.Point(0, 0);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(75, 23);
            this.buttonAlarm.TabIndex = 0;
            this.buttonAlarm.Text = "Alarm";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(691, -50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 232);
            this.panel1.TabIndex = 20;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(691, 441);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 565);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridViewLogs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.doorRight_1);
            this.Controls.Add(this.doorLeft_1);
            this.Controls.Add(this.doorRight_G);
            this.Controls.Add(this.doorLeft_G);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_G);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.liftPanel);
            this.Controls.Add(this.mainElevator);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox mainElevator;
		private System.Windows.Forms.PictureBox liftPanel;
		private System.Windows.Forms.Button btn_1;
		private System.Windows.Forms.Button btn_G;
		private System.Windows.Forms.Button btn_Open;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Timer liftTimerUp;
		private System.Windows.Forms.PictureBox doorLeft_G;
		private System.Windows.Forms.PictureBox doorRight_G;
		private System.Windows.Forms.PictureBox doorRight_1;
		private System.Windows.Forms.PictureBox doorLeft_1;
		private System.Windows.Forms.Timer doorTimer;
		private System.Windows.Forms.DataGridView dataGridViewLogs;
		private System.Windows.Forms.Timer liftTimerDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteButton;
    }
}

