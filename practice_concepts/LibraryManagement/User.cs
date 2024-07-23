public class User
{
    public string Name{get;set;}

    private int userid;
    private string username;
    public int UId
    {
        get
        {
            return userid;
        }
    }
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
                lib.books.Remove(book);
            }
        }
    }
    public void BorrowBook(int isbn)
    {
        foreach(Book book in lib.books)
        {
            if(book.ISBN == isbn)
            {
                book.RemoveCopy();
                Console.WriteLine($"Copies {book.Title} available now - {book.CopiesAvailable}");
            }
        }
        
    }

    public void ReturnBook(int isbn)
    {
        foreach(Book book in lib.books)
        {
            if(book.ISBN == isbn)
            {
                book.AddCopy();
                Console.WriteLine($"Copies {book.Title} available now - {book.CopiesAvailable}");
            }
        }
    }
}