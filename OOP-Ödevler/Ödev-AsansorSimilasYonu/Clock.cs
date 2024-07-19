public class Clock
{
    private DateTime currentTime;

    public Clock()
    {
        currentTime = DateTime.Now;
    }

    public DateTime GetCurrentTime()
    {
        return currentTime;
    }

    public void LogEvent(string eventDescription)
    {
        Console.WriteLine($"[{currentTime}] {eventDescription}");
    }
}
