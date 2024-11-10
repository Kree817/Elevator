namespace ElevatorProject
{
     public interface IDoorState
    {
        void OpenDoor(MainForm form);
        void CloseDoor(MainForm form);
        bool IsDoorOpen(); // Add this method
    }
}
