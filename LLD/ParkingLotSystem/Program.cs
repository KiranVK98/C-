// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;

public enum VehicleType {car,bike}
public class Ticket
{
    public string ticketID {get;}
    public DateTime entryTime {get;}

    public Ticket(string ticketid, DateTime entrytime)
    {
        this.ticketID = ticketid;
        this.entryTime = entrytime;
    }
}


public class Vehicle
{
    public VehicleType vehicleType {get;}
    public string vehicleModel {get;}
    public string vehicleColor {get;}
    public string vehicleNumber {get;}


    public Vehicle(VehicleType vehicletype, string vehiclemodel, string vehiclecolor, string vehiclenumber)
    {
        this.vehicleType = vehicletype;
        this.vehicleModel = vehiclemodel;
        this.vehicleColor = vehiclecolor;
        this.vehicleNumber = vehiclenumber;

    }
}

public class ParkingLot
{
    Dictionary<Vehicle, Ticket> parkedVehicles = new Dictionary<Vehicle, Ticket>();

    Dictionary<VehicleType, int> capaci;
    private int capacity;

    private ParkCar carCapacity;

    private ParkBike bikeCapacity; 
    public ParkingLot(int Capacity, Dictionary<VehicleType, int> caps)
    {
        this.capacity = Capacity;
        this.capaci = caps;
        this.carCapacity = new ParkCar(this.capaci[VehicleType.car]);
        this.bikeCapacity = new ParkBike(this.capaci[VehicleType.bike]);
        
    }

    public Ticket generateTicket()
    {
        var ticketId = Guid.NewGuid().ToString();
        var ticket = new Ticket(ticketId, DateTime.Now);
        return ticket;
    }

    public void parkCar(Vehicle car)
    {
        Ticket getTicket = generateTicket();
        this.carCapacity.pCar(getTicket, car, this.parkedVehicles);
    }

    public void parkBike(Vehicle bike)
    {
        Ticket getTicket = generateTicket();
        this.bikeCapacity.pBike(getTicket, bike, this.parkedVehicles);
    }


    public void vehicleGarage()
    {
        foreach(KeyValuePair<Vehicle,Ticket> veh in parkedVehicles)
        {
            Console.WriteLine($"Vehicle {veh.Key.vehicleType} model - {veh.Key.vehicleModel} with number {veh.Key.vehicleNumber} parked");
            if(veh.Key.vehicleType == VehicleType.car)
            {
                Console.WriteLine($"Remaining car slots are {carCapacity.CarCapacity}");
            }
            else
            {
                Console.WriteLine($"Remaining bike slots are {bikeCapacity.BikeCapacity}");

            }
        }
    }   

}


public class ParkCar
{
    private int carCapacity;

    public int CarCapacity
    {
        get {return carCapacity; }
    }
    public ParkCar(int carCapacity)
    {
        this.carCapacity = carCapacity;
    }

    public void pCar(Ticket t, Vehicle c, Dictionary<Vehicle, Ticket> veh)
    {
        if(carCapacity <= 0)
        {
            Console.WriteLine($"Sorry the car capacity is full");
        }
        else
        {
            carCapacity -= 1;
            veh.Add(c,t);
        }
    }
}

public class ParkBike
{
    private int bikeCapacity;

    public int BikeCapacity
    {
        get{ return bikeCapacity; }
    } 
    public ParkBike(int carCapacity)
    {
        this.bikeCapacity = carCapacity;
    }

    public void pBike(Ticket t, Vehicle c, Dictionary<Vehicle, Ticket> veh)
    {
        if(bikeCapacity <= 0)
        {
            Console.WriteLine($"Sorry the bike capacity is full");
        }
        else
        {
            bikeCapacity -= 1;
            veh.Add(c,t);
        }
    }
}

class main
{
    public static void Main(String[] args)
    {
        ParkingLot pL = new ParkingLot(100,new Dictionary<VehicleType, int>()
            {
                {VehicleType.car, 1},
                {VehicleType.bike, 20}
            });
        pL.parkCar(new Vehicle(
            VehicleType.car,
             "Corolla",
             "silver",
            "2014"
        ));

        pL.parkCar(new Vehicle(
            VehicleType.car,
             "Civic",
             "silver",
            "2014"
        ));

        pL.parkBike(new Vehicle(
            VehicleType.bike,
             "Pulsar",
             "silver",
            "2014"
        ));

        pL.vehicleGarage();
        
    }
}
