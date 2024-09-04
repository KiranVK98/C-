public class testClass
{
    public void testDict()
    {
    Students st = new Students(){name = "Kiran", email = "kvk@gmail.com" , phoneNumber=94567};
    Students st1 = new Students(){name = "Ravi", email = "kvk@gmail.com" , phoneNumber=94567};

    Students st2 = new Students(){name = "Sup", email = "kvk@gmail.com" , phoneNumber=94567};


    Dictionary<string, Students> stuFetch = new Dictionary<string, Students>();

    stuFetch.Add(st.name,st);
    stuFetch.Add(st1.name,st1);
    stuFetch.Add(st2.name,st2);

    Console.WriteLine("Enter the name of the student to be fetched");
    string fetch = (string)(Console.ReadLine());

    Students result = stuFetch.ContainsKey(fetch) ? stuFetch[fetch] : null;

    if(result == null)
    {
        Console.WriteLine("Student name is invalid");
    }
    else
        Console.WriteLine($"Name - {result.name} , Phone - {result.phoneNumber} , Email - {result.email}");

    }

}


public class Students
{
    public string name;
    public string email;

    public int phoneNumber;
}