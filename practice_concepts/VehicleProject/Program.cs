// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(String[] args)
    {
     
        List<Vehicle> vehicles= new List<Vehicle>
        {
            new Car("Toyota", "Corolla", 2020),
            new Bike("Yamaha", "YZF-R3", 2019)
        };

        foreach(Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            if(vehicle is Driveable drives)
            {
                drives.drive();
            }
        }
    }
}
