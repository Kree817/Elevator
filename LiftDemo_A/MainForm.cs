using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace ElevatorProject
{
    public partial class MainForm : Form
    {
        private bool isOpening = false;
        private bool isClosing = false;

        private int doorMaxOpenWidth;
        private int doorSpeed = 5;
        private int liftSpeed = 5;

        private IDoorState _currentDoorState;
        private SoundPlayer alarmSound;
        private bool isAlarmActive = false;

        private Elevator lift;
        private DataTable dt = new DataTable();
        private DBContext dbContext = new DBContext();

        public MainForm()
        {
            InitializeComponent();

            _currentDoorState = new DoorClosedState();
            lift = new Elevator(mainElevator, btn_1, btn_G, this.ClientSize.Height, liftSpeed, liftTimerUp, liftTimerDown);

            alarmSound = new SoundPlayer("C:\\Users\\Lenovo\\Downloads\\alarmsound.wav");

            doorMaxOpenWidth = mainElevator.Width / 2 - 30;

            dataGridViewLogs.ColumnCount = 2;
            dataGridViewLogs.Columns[0].Name = "Time";
            dataGridViewLogs.Columns[1].Name = "Events";

            dt.Columns.Add("LogTime");
            dt.Columns.Add("EventDescription");
        }

        public void logEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");

            dt.Rows.Add(currentTime, message);
            dataGridViewLogs.Rows.Add(currentTime, message);

            dbContext.InsertLogsIntoDB(dt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbContext.loadLogsFromDB(dt, dataGridViewLogs);
        }

        public void btn_1_click(object sender, EventArgs e)
        {
            if (!_currentDoorState.IsDoorOpen())
            {
                lift.SetState(new MovingUpState());
                lift.LiftTimerUp.Start();
                btn_G.Enabled = false;
                logEvents("Elevator Moving Up");
            }
            else
            {
                logEvents("Cannot move, doors are open.");
                //btn_G.Enabled = true;

            }
        }

        public void btn_G_click(object sender, EventArgs e)
        {
            if (!_currentDoorState.IsDoorOpen())
            {
                lift.SetState(new MovingDownState());
                lift.LiftTimerDown.Start();
                btn_1.Enabled = false;
                logEvents("Elevator Moving Down");
            }
            else
            {
                logEvents("Cannot move, doors are open.");
                //btn_1.Enabled = true;

            }
        }

        public void liftTimerUp_Tick(object sender, EventArgs e)
        {
            lift.MovingUp();
            if (lift.MainElevator.Top <= 0)
            {
                lift.LiftTimerUp.Stop();
                logEvents("Elevator reached 1st floor.");
                lift.UpdateFloor("1st");
                _currentDoorState.OpenDoor(this); // Automatically open 1st floor doors
            }
        }

        public void liftTimerDown_Tick(object sender, EventArgs e)
        {
            lift.MovingDown();
            if (lift.MainElevator.Top >= lift.FormSize - lift.MainElevator.Height)
            {
                lift.LiftTimerDown.Stop();
                logEvents("Elevator reached Ground floor.");
                lift.UpdateFloor("Ground");
                _currentDoorState.OpenDoor(this); // Automatically open Ground floor doors
            }
        }

        public void SetDoorState(IDoorState state)
        {
            _currentDoorState = state;
        }

        public void StartOpeningDoors()
        {
            isOpening = true;
            isClosing = false;
            doorTimer.Start();
            btn_Close.Enabled = false;
        }

        public void StartClosingDoors()
        {
            isOpening = false;
            isClosing = true;
            doorTimer.Start();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            _currentDoorState.OpenDoor(this);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            _currentDoorState.CloseDoor(this);
        }

        private void door_Timer_Tick(object sender, EventArgs e)
        {
            if (lift.CurrentFloor == "1st")
            {
                ManageDoorMovement(doorLeft_1, doorRight_1); // 1st floor doors
            }
            else if (lift.CurrentFloor == "Ground")
            {
                ManageDoorMovement(doorLeft_G, doorRight_G); // Ground floor doors
            }
        }

        private void ManageDoorMovement(Control doorLeft, Control doorRight)
        {
            if (isOpening)
            {
                if (doorLeft.Left > doorMaxOpenWidth / 2)
                {
                    doorLeft.Left -= doorSpeed;
                    doorRight.Left += doorSpeed;
                }
                else
                {
                    doorTimer.Stop();
                    btn_Close.Enabled = true;
                    btn_G.Enabled = true;
                    btn_1.Enabled = true;

                }
            }

            if (isClosing)
            {
                if (doorLeft.Right < mainElevator.Width + doorMaxOpenWidth / 2 - 5)
                {
                    doorLeft.Left += doorSpeed;
                    doorRight.Left -= doorSpeed;
                }
                else
                {
                    doorTimer.Stop();
                    btn_G.Enabled = true;
                    btn_1.Enabled = true;


                }
            }
        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            if (isAlarmActive)
            {
                ResetAlarm();
            }
            else
            {
                logEvents("Alarm Activated!");
                lift.LiftTimerUp.Stop();
                lift.LiftTimerDown.Stop();
                doorTimer.Stop();
                _currentDoorState.OpenDoor(this);
                alarmSound.PlayLooping();
                buttonAlarm.BackColor = Color.Red;
                buttonAlarm.Text = "Alarm Activated";
                isAlarmActive = true;
            }
        }

        private void ResetAlarm()
        {
            logEvents("Alarm Reset");
            alarmSound.Stop();
            _currentDoorState.CloseDoor(this);
            buttonAlarm.BackColor = SystemColors.Control;
            buttonAlarm.Text = "Alarm";
            isAlarmActive = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all logs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dbContext.DeleteAllLogs();
                dt.Rows.Clear(); // Clear the DataTable
                dataGridViewLogs.Rows.Clear(); // Clear the DataGridView
                logEvents("All logs deleted.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridViewLogs.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewLogs.SelectedRows[0];
                DateTime logTime = DateTime.Parse(selectedRow.Cells["Time"].Value.ToString());

                dbContext.DeleteSelectedLog(logTime);
                dataGridViewLogs.Rows.RemoveAt(selectedRow.Index); // Remove the selected row from DataGridView
                logEvents("Selected log deleted.");
            }
            else
            {
                MessageBox.Show("Please select a log to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
