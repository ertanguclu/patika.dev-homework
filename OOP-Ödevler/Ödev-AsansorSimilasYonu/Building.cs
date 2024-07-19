using System;
using System.Collections.Generic;

public class Building
{
    private int floors;
    private List<Elevator> elevators;
    private List<List<FloorDoor>> floorsDoors;
    private List<ArrivalBell> arrivalBells;

    public Building(int floors, int elevatorCount)
    {
        this.floors = floors;
        elevators = new List<Elevator>();
        floorsDoors = new List<List<FloorDoor>>();
        arrivalBells = new List<ArrivalBell>();

        // Initialize elevators
        for (int i = 0; i < elevatorCount; i++)
        {
            Elevator elevator = new Elevator(i);
            elevators.Add(elevator);
        }

        // Initialize floors and floor doors
        for (int i = 0; i < floors; i++)
        {
            List<FloorDoor> doorsOnFloor = new List<FloorDoor>();
            for (int j = 0; j < elevatorCount; j++)
            {
                FloorDoor floorDoor = new FloorDoor();
                doorsOnFloor.Add(floorDoor);
            }
            floorsDoors.Add(doorsOnFloor);

            ArrivalBell arrivalBell = new ArrivalBell();
            arrivalBells.Add(arrivalBell);
        }
    }

    public void CallElevator(int floor, Direction direction)
    {
        // Logic to call the nearest available elevator
        // Example: elevators[0].MoveTo(floor);
    }
}
