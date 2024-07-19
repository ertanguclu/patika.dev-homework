public class Airline
{
    private int airlineId;
    private string name;
    private List<Airplane> airplanes;

    public Airline(int airlineId, string name)
    {
        this.airlineId = airlineId;
        this.name = name;
        this.airplanes = new List<Airplane>();
    }

    public void AddAirplane(Airplane airplane)
    {
        airplanes.Add(airplane);
    }

    public void ScheduleFlight(int flightId, Airport departureAirport, Airport destinationAirport, DateTime departureTime, Pilot pilot, Pilot coPilot)
    {
        // Uçak ataması
        var availableAirplanes = GetAvailableAirplanes();
        if (availableAirplanes.Count > 0)
        {
            Airplane assignedAirplane = availableAirplanes[0]; // Varsayılan olarak ilk uçağı ata
            assignedAirplane.MarkAsUnavailable(); // Uçağı kullanılamaz yap
            Flight newFlight = new Flight(flightId, departureAirport, destinationAirport, departureTime, pilot, coPilot, assignedAirplane);
            // Uçuşu planlama veya başka bir işlem yapma
        }
        else
        {
            Console.WriteLine("No available airplanes for scheduling.");
        }
    }

    public List<Airplane> GetAvailableAirplanes()
    {
        return airplanes.FindAll(a => a.IsAvailable);
    }
}

// Airplane sınıfı
public class Airplane
{
    private int airplaneId;
    private string airplaneType;
    private bool isAvailable;
    private Airline airline;

    public Airplane(int airplaneId, string airplaneType, Airline airline)
    {
        this.airplaneId = airplaneId;
        this.airplaneType = airplaneType;
        this.isAvailable = true;
        this.airline = airline;
    }

    public void MarkAsAvailable()
    {
        isAvailable = true;
    }

    public void MarkAsUnavailable()
    {
        isAvailable = false;
    }
}

// Flight sınıfı
public class Flight
{
    private int flightId;
    private Airport departureAirport;
    private Airport destinationAirport;
    private DateTime departureTime;
    private Pilot pilot;
    private Pilot coPilot;
    private Airplane airplane;

    public Flight(int flightId, Airport departureAirport, Airport destinationAirport, DateTime departureTime, Pilot pilot, Pilot coPilot, Airplane airplane)
    {
        this.flightId = flightId;
        this.departureAirport = departureAirport;
        this.destinationAirport = destinationAirport;
        this.departureTime = departureTime;
        this.pilot = pilot;
        this.coPilot = coPilot;
        this.airplane = airplane;
    }

    public void AssignAirplane(Airplane airplane)
    {
        this.airplane = airplane;
    }
}

// Airport sınıfı
public class Airport
{
    private int airportId;
    private string name;

    public Airport(int airportId, string name)
    {
        this.airportId = airportId;
        this.name = name;
    }
}

// Pilot sınıfı
public class Pilot
{
    private int pilotId;
    private string name;
    private string experienceLevel;
    private List<string> airplanesQualified;
    private Airline airline;

    public Pilot(int pilotId, string name, string experienceLevel, Airline airline)
    {
        this.pilotId = pilotId;
        this.name = name;
        this.experienceLevel = experienceLevel;
        this.airplanesQualified = new List<string>();
        this.airline = airline;
    }

    public void AddQualifiedAirplane(string type)
    {
        airplanesQualified.Add(type);
    }
}