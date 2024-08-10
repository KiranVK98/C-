public class Library
{
    private List<Book> lib;

    public void Add_Book(string title,string author,string iSBN)
    {
        lib = new List<Book>();
        lib.Add(new Book(){
            Title = title,
            Author = author,
            ISBN = iSBN,
            IsCheckedOut = false
        });
    }


    public Book Search_Author(string author)
    {
        return lib.FirstOrDefault(library => library.Author == author);
    }


    public string Search_Title(string title)
    {
        return lib.FirstOrDefault(library => library.Title == title).Title;
    }

    public void check_out(string isbn)
    {
        foreach(Book book in lib)
        {
            if(book.ISBN == isbn)
            {
                if(book.IsCheckedOut == true)
                {
                    Console.WriteLine("Sorry this book is already borrowed");
                }
                else
                {
                    Console.WriteLine("Book given");
                    book.IsCheckedOut = true;

                }
            }
        }
    }



}