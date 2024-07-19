public interface ElevatorObserver
{
    void Update(int floor, ElevatorStatus status, bool isOpen);
}

public class RandomGenerator
{
    private Random random;

    public RandomGenerator()
    {
        random = new Random();
    }

    public int GenerateRandomFloor(int currentFloor)
    {
        // Generate random floor different from currentFloor
        int floor = random.Next(0, 12); // Assuming 12 floors
        while (floor == currentFloor)
        {
            floor = random.Next(0, 12);
        }
        return floor;
    }
}
