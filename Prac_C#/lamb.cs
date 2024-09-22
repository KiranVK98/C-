public class pracLambda
{
    public List<studentLambda> stuLamb;
    public pracLambda()
    {
        stuLamb = new List<studentLambda>()
        {
            new studentLambda(){
                id = 1,
                name = "Kiran",
                email = "kvk@gmail.com"
            },
            new studentLambda(){
                id = 2,
                name = "Sups",
                email = "sup@gmail.com"
            }
        };
    }

    public delegate bool stuDelegate(studentLambda let, string letter);

    public bool Findstu(studentLambda sL, string letter)
    {
        if(sL.name.StartsWith(letter))
        {
            return true;
        }
        return false;
    }
    public void findStudent(string letter)
    {
        stuDelegate sD = new stuDelegate(Findstu);

        studentLambda ret = stuLamb.Find(val => sD(val,letter));
        // studentLambda ret = stuLamb.Find(Name => Name.name.StartsWith(letter));
        if(ret!=null)
        {
        Console.WriteLine($"Student name is {ret.name} and email - {ret.email}");
        }
        else{
            Console.WriteLine($"There is no student whose name starts from {letter}");
        }
    }
}



public class studentLambda
{
    public int id{get;set;}

    public string name {get;set;}

    public string email {get;set;}
}