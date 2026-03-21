// constructor that initialise instance field vs constructor that initialise static field.

public class StaticConstructor
{
    public int empId;
    public string empName;
    public static string companyName;

    public StaticConstructor(int empId, string empName)
    {
        this.empId = empId;
        this.empName = empName;
    }

    static StaticConstructor()
    {
        StaticConstructor.companyName = "ABC Company";
    }
}


public class dProgram
{
    public static void dMain()
    {
        StaticConstructor c1 = new StaticConstructor(101, "John");
        Console.WriteLine(c1.empId + "\n" + c1.empName + "\n"+StaticConstructor.companyName);
    }
}