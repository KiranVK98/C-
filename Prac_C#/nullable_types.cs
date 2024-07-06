//by default value types like int,float,double are not nullable, to make it nullable just put ?

public class types 
{
    public void computation()
    {
        int ?i = null;
        
        int AvailableTickets = i ?? 0; // we use this to avoid casting i to int

        Console.WriteLine(AvailableTickets);
    }
}