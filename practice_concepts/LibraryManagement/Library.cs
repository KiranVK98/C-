public class Library
{
    public List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        // Console.WriteLine($"Book {book.Title} added");
    }


    public void RemoveBook(int isbn)
    {
        foreach(var book in books)
        {
            if(book.ISBN == isbn)
            {
                books.Remove(book);
                break;
            }
        }
        
    }



    public Book FindBookByTitle(string title)
    {
        foreach(var book in books)
        {
            if(book.Title == title)
            {
                return book;
            }
        }

        return null;
    }

    public Book FindBookByAuthor(string author)
    {
        foreach(Book book in books)
        {
            if(book.Author == author)
            {
                return book;
            }
        }

        return null;
    }



}