public class Person
{
    private string _Name;
    private int _Age;

    public string Name
    {
        set
        {
            if(value == null)
            {
                throw new Exception();
            }
            _Name = value;
        }

        get
        {
            return _Name;
        }
    }


    public int Age
    {
        set
        {
            if(value == null)
            {
                throw new Exception();
            }

            _Age = value;
        }

        get
        {
            return _Age;
        }
    }

}