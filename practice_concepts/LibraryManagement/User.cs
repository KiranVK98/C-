public class User
{
    public string Name{get;set;}

    public string UserId {get;set;}

    private int userid;
    private string username;


    public User(int UserId, string UserName)
    {
        this.userid = UserId;
        this.username = UserName;
    }
    Library lib = new Library();



    public void AddB(Book book)
    {
        lib.AddBook(book);
        Console.WriteLine($"The book {book.Title} was added by {username}");
    }

    public void RemoveB(int isbn)
    {
        foreach(Book book in lib.books)
        {
            if(book.ISBN == isbn)
            {
                lib.RemoveBook(book.ISBN);
            }
        }
    }
    public void BorrowBook(int isbn)
    {
        
    }
}