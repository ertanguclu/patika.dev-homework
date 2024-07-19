using System;
using System.Collections.Generic;

public enum ElevatorStatus
{
    Idle,
    Moving,
    DoorsOpening,
    DoorsClosing
}

public class Elevator
{
    private int elevatorId;
    private int currentFloor;
    private List<int> destinationFloors;
    private ElevatorStatus status;
    private List<Door> doors;
    private ControlPanel controlPanel;
    private List<ElevatorObserver> observers;

    public Elevator(int elevatorId)
    {
        this.elevatorId = elevatorId;
        currentFloor = 0;
        destinationFloors = new List<int>();
        status = ElevatorStatus.Idle;
        doors = new List<Door>();
        controlPanel = new ControlPanel(elevatorId);
        observers = new List<ElevatorObserver>();
    }

    public void Move()
    {
        // Logic to move the elevator to the next destination floor
        // Example: currentFloor++;
    }

    public void OpenDoors()
    {
        // Logic to open the elevator doors
        // Example: doors[0].Open();
    }

    public void CloseDoors()
    {
        // Logic to close the elevator doors
        // Example: doors[0].Close();
    }

    public void AddDestination(int floor)
    {
        destinationFloors.Add(floor);
    }

    public void SetStatus(ElevatorStatus status)
    {
        this.status = status;
        NotifyObservers();
    }

    public void RegisterObserver(ElevatorObserver observer)
    {
        observers.Add(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(currentFloor, status, doors[0].IsOpen);
        }
    }
}
