public class InstanceConstructor
{
    public int empId;
    public string empName;

    public InstanceConstructor(int empId, string empName)
    {
        this.empId = empId;
        this.empName = empName;
    }
}

public class rProgram
{
    public static void rMain()
    {
        InstanceConstructor c1 = new InstanceConstructor(101, "Johnn");
        InstanceConstructor c2 = new InstanceConstructor(102, "Donn");
        Console.WriteLine("Emp. 1 ID: "+c1.empId+"\n"+ "Emp. Name: " + c1.empName);
        Console.WriteLine("\n \nEmp. 2 ID: " + c2.empId + "\n" + "Emp. Name: " + c2.empName);
    }
}
