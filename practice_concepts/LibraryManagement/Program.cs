class Program
{
    public static void Main(String[] args)
    {
        User user = new User(1, "Kiran");

        List<User> users = new List<User>();

        users.Add(user);


        foreach(User test in users)
        {
            test.AddB(new Book("Ikigai","Kiran",123,1));
        }
    }
}