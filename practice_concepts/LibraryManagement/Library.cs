public class Library
{
    public List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }


    public void RemoveBook(string isbn)
    {
        foreach(Book book in books):
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
        foreach(Book book in books):
        {
            if(book.Title == title)
            {
                return book;
            }
        }
    }

    public Book FindBookByAuthor(string author)
    {
        foreach(Book book in books):
        {
            if(book.Author == author)
            {
                return book;
            }
        }
    }



}