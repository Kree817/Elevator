namespace ElevatorProject
{
    internal class DoorClosedState : IDoorState
    {
        public void OpenDoor(MainForm form)
        {
            form.SetDoorState(new DoorOpenState());
            form.StartOpeningDoors();
            form.logEvents("Doors Opening");
        }

        public void CloseDoor(MainForm form)
        {
            // Already closed, do nothing
        }

        public bool IsDoorOpen()
        {
            return false; // Doors are closed
        }
    }
}
