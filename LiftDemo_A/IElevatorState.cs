using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject
{
	internal interface IElevatorState
	{
		void MovingUp(Elevator lift);
		void MovingDown(Elevator lift);
	}
}
