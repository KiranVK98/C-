public class Vehicle
{
    private string _Make;
    private string _Model;
    private int _Year;

    public Vehicle (string Make, string Model, int Year)
    {
        this._Make = Make;
        this._Model = Model;
        this._Year = Year;
    }

    public string Make
    {
        get 
        {
            return _Make;
        }
    }

     public string Model
    {
        get 
        {
            return _Model;
        }
    }

     public int Year
    {
        get 
        {
            return _Year;
        }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Displaying Vehicle Information");
    }
}


public class Car : Vehicle, Driveable
{
    public Car(string Make, string Model, int Year) : base(Make, Model, Year)
    {}

    public override void DisplayInfo()
    {
        Console.WriteLine($"Your Car - {Make} , your model - {Model} -  your year - {Year}");
    }

    public void drive()
    {
        Console.WriteLine("Car is driving");
    }
}



public class Bike : Vehicle, Driveable
{
    public Bike(string Make, string Model, int Year) : base(Make, Model, Year)
    {
    }


    public override void DisplayInfo()
    {
        Console.WriteLine($"Your Bike - {Make} , your model - {Model} -  your year - {Year}");
    }

       public void drive()
    {
        Console.WriteLine("Bike is driving");
    }
}



