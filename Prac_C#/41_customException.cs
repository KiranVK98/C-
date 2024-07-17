public class AddTwoNumbers
{

    public void Add(int n1, string n2)
    {
        try 
        {
            Console.WriteLine(n1/0);
        }
        catch(Exception ex)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, "output.txt");
            StreamWriter sr = new StreamWriter(filePath);
            sr.Write(ex.GetType().Name);
            sr.Close();
            Console.WriteLine("Some prob try again later");

        }



    }



}