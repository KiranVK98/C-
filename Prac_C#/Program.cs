// See https://aka.ms/new-console-template for more information
using System;
// using PATA = project.TeamA;
// using PATB = project.TeamB;
// using patA = ProjectA.TeamA;
public delegate int Add_Number(int n1, int n2);
class Program 
{
    public static void Main(string[] args)
    {

        testClass tc = new testClass();

        tc.testDict();

        // Test t = new Test1();

        // t.SayHello();



        // //Indexers
        // Library lib = new Library();
        // Console.WriteLine(lib[1]);



        // //Exceptions
        // AddTwoNumbers add = new AddTwoNumbers();
        // add.Add(2,"wes");



    //     //Delegates
    //       List<TestDelegate> inp = new List<TestDelegate>(){
    //     new TestDelegate(){N1 = 2, N2 = 3},
    //     new TestDelegate(){N1 = 4, N2 = 3},
    //     new TestDelegate(){N1 = 3, N2 = 3}

    // };

    // Integer_Computation test_Add = new Integer_Computation(TestDelegate.AddN);
    // TestDelegate.Compute(inp, test_Add);

    // Integer_Computation test_Mul = new Integer_Computation(TestDelegate.MulN);
    // TestDelegate.Compute(inp, test_Mul);





        // // Multiple Inheritance using interfaces
        // meth m1 = new meth();
        // m1.Compute(2,3);
        // m1.Compute_multiply(2,3);


        // //get_set property
        // Student student = new Student();
        // student.Name = "Kiran";
        // Console.WriteLine($"Name is {student.Name}");


        // //Inheritance
        // fullTime Femp = new fullTime("Kiran", "Kulkarni", 70000,"Hello base class");
        // Femp.print_fullName();
        // Femp.print_Salary();

        // partTime Pemp = new partTime("Kiran", "VK");
        // Pemp.print_fullName();



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
