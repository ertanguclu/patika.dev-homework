public class FloorDoor
{
    private Door door;
    private ArrivalBell arrivalBell;

    public FloorDoor()
    {
        door = new Door(0); // Assuming one door per floor door
        arrivalBell = new ArrivalBell();
    }

    public void Open()
    {
        door.Open();
    }

    public void Close()
    {
        door.Close();
    }

    public void RingBell()
    {
        arrivalBell.Ring();
    }
}
