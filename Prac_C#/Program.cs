// See https://aka.ms/new-console-template for more information
using System;
using PATA = project.TeamA;
using PATB = project.TeamB;
using patA = ProjectA.TeamA;
class Program 
{
    public static void Main(string[] args)
    {

        //Inheritance
        fullTime Femp = new fullTime("Kiran", "Kulkarni", 70000,"Hello base class");
        Femp.print_fullName();
        Femp.print_Salary();

        partTime Pemp = new partTime("Kiran", "VK");
        Pemp.print_fullName();



        // patA.TeamA.Print();
        // PATB.teamB.Print();



        // int j;
        // int Sum;
        // int Prod;
        // method_params meth = new method_params(out j, out Sum, out Prod);
        // Console.WriteLine($"j - {j}, Sum - {Sum}, Prod - {Prod}");

        // int[] new_arr = new int[3];
        // method_params.test_params(ref new_arr);
        // foreach (int item in new_arr)
        // {
        //     Console.WriteLine(item);
        // }
        // pWhile test = new pWhile();
        // test.prac_while();  // while loop

        // Test test = new Test();
        // test.SayHello();

        // DataTypes bl = new DataTypes();
        // bl.Is_Boolean(true);

        // strings s = new strings();
        // s.computation();

        // operators op = new operators();
        // op.computation(11);

        // types t = new types();
        // t.computation();

        // array test = new array();
        // test.test_array();

        // switch_class test = new switch_class();
        // test.test_switch();

    }
}
