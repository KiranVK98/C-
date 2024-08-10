public class Program
{
    public static void Main(String[] args)
    {
        Book ret_value;
        Library lib = new Library();
        lib.Add_Book("A","Kiran","123456");
        ret_value = lib.Search_Author("Kiran");

        Console.WriteLine($"Book name {ret_value.Title}");
        Console.WriteLine($"Book name {ret_value.Author}");
        Console.WriteLine($"Book name {ret_value.ISBN}");
        lib.check_out("123456");

    }
}