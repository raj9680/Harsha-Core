// readonly and write only property

public class Pxrogram
{
    private static int _salary;
    public static int Salary // readonly prop. dont have set accessor
    {
        get { return 2000; } 
    }


    private static string _gender;
    public static string Gender // writeonly prop. dont have get accessor
    {
        set { _gender = value; }
    }


    public static void Mxain()
    {
        Gender = "Male";
        Console.WriteLine("Salary is: "+Salary);
        //Console.WriteLine("Gender is: "+ Gender); // cannot read as not get accessor
    }
}