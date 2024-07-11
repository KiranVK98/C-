public class Student
{   

    public string _city{get;set;}
    private string _Name;
    public string Name
    {
        set 
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new Exception("Not valid");
            }
            this._Name = value;
        }

        get
        {
            return string.IsNullOrEmpty(_Name) ? "No Name" : this._Name;
        }
    }
}