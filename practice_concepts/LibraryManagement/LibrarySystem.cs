public class LibrarySystem
{
    List<User> users = new List<User>();

    public void RegisterUser(User user)
    {
        users.Add(user);
    }


    public void UnRegisterUser(int userId)
    {
        foreach(User u in users)
        {
            if(u.UId == userId)
            {
                users.Remove(u);
            }
        }
    }

    public void AddBook(Book book, int userid)
    {
        foreach(User user in users)
        {
            if(user.UId == userid)
            {
                user.AddB(book);
            }
        }
    }

    public void RemoveBook(int isbn, int userid)
    {
        foreach(User user in users)
        {
            if(user.UId == userid)
            {
                user.RemoveB(isbn);
            }
        }
    }

    public void BorrowBook(int userid , int isbn)
    {
        foreach(User user in users)
        {
            if(user.UId == userid)
            {
                user.BorrowBook(isbn);
            }
        }
    }

    public void ReturnBook(int userid , int isbn)
    {
        foreach(User user in users)
        {
            if(user.UId == userid)
            {
                user.ReturnBook(isbn);
            }
        }
    }

}