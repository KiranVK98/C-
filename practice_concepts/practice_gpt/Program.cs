// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(String[] args)
    {

        //Abstraction
        FullTimeEmployee FTE = new FullTimeEmployee();
        PartTimeEmployee PTE = new PartTimeEmployee();
        FTE.CalculateSalary();
        PTE.CalculateSalary();


        //Polymorphism
        // List<Shape> shapes = new List<Shape>
        // {
        //     new Circle(),
        //     new Square()
        // };

        // foreach(Shape shap in shapes)
        // {
        //     shap.Draw();
        // }


        // //Inheritance
        // Animal d = new Dog();
        // d.Speak();


        //Encapsulation
        // Person person = new Person();
        // person.Name = "Kiran";
        // person.Age = 26;

        // Console.WriteLine($"Nmame is {person.Name} and age is {person.Age}");

        // //Creating class
        // create_class test = new create_class();
    
    }
}
