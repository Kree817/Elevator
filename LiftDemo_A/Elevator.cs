using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorProject
{
	internal class Elevator
	{
		public IElevatorState _CurrentState;

		public PictureBox MainElevator;
		public Button Btn_1;
		public Button Btn_G;
		public int FormSize;
		public int LiftSpeed;
		public Timer LiftTimerUp;
		public Timer LiftTimerDown;

		public Elevator(PictureBox mainElevator, Button btn_1, Button btn_G, int formSize, int liftSpeed, Timer liftTimerUp, Timer liftTimerDown)
		{
			MainElevator = mainElevator;
			Btn_1 = btn_1;
			Btn_G = btn_G;
			FormSize = formSize;
			LiftSpeed = liftSpeed;
			LiftTimerUp = liftTimerUp;
			LiftTimerDown = liftTimerDown;
			_CurrentState = new IdleState();
		}


        public string CurrentFloor { get; private set; } // Add this property

        public void UpdateFloor(string floor)
        {
            CurrentFloor = floor; // Update the current floor
        }
        
		public void SetState(IElevatorState state)
		{
			_CurrentState = state;
		}

		public void MovingUp()
		{
			_CurrentState.MovingUp(this);
		}

		public void MovingDown()
		{
			_CurrentState.MovingDown(this);
		}


	}
}
