namespace ElevatorProject
{
    internal class DoorOpenState : IDoorState
    {
        public void OpenDoor(MainForm form)
        {
            // Already open, do nothing
        }

        public void CloseDoor(MainForm form)
        {
            form.SetDoorState(new DoorClosedState());
            form.StartClosingDoors();
            form.logEvents("Doors Closing");
        }

        public bool IsDoorOpen()
        {
            return true; // Doors are open
        }
    }
}
