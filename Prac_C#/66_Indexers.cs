public class Book
{
    public int BookId {get;set;}
    public string BookName {get;set;}

    public string AuthorName {get;set;}

}

public class Library
{
    private List<Book> libList;

    public Library()
    {
        libList = new List<Book>();

        libList.Add(new Book(){
            BookId = 1, BookName = "Kiran" , AuthorName = "Kiran"
        });

        libList.Add(new Book(){BookId = 2, BookName = "K1" , AuthorName="K1"});
    }


    public string this[int BookId]
    {
        get
        {
            return libList.FirstOrDefault(lib => lib.BookId == BookId).BookName;
        }

        
    }
}