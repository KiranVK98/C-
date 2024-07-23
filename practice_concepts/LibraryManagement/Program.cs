class Program
{
    public static void Main(String[] args)
    {
        LibrarySystem library = new LibrarySystem();

        library.RegisterUser(
            new User(17,"Kiran")
        );

        library.AddBook(
            new Book("Coding","Kiran",1,1),
            17
        );

        library.BorrowBook(17,1);

        library.ReturnBook(17, 1);

    }
}