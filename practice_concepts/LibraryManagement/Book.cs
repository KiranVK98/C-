public class Book
{
    public string Title{get;set;}
    public string Author{get;set;}
    public int ISBN{get;set;}
    public int CopiesAvailable{get;set;}

    public Book(string title, string author, int isbn, int copiesavailable)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
        this.CopiesAvailable = copiesavailable;
    }


    public void AddCopy()
    {
        CopiesAvailable += 1;
    }

    public void RemoveCopy()
    {
        CopiesAvailable -= 1;
    }
}