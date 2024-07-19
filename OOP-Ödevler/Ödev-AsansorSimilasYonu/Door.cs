public class Door
{
    private int doorId;
    private bool isOpen;

    public Door(int doorId)
    {
        this.doorId = doorId;
        isOpen = false;
    }

    public void Open()
    {
        isOpen = true;
    }

    public void Close()
    {
        isOpen = false;
    }

    public bool IsOpen
    {
        get { return isOpen; }
    }
}
