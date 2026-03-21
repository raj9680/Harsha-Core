using System.Net;

public class Prgoram
{
    public static void Main()
    {
        Employee employee = new Employee(101, "Raj", "Developer");
        Console.WriteLine(employee.empId);
        Console.WriteLine(employee.empName);
        Console.WriteLine(employee.job);

        Console.WriteLine("\nWebsite is: "+ Employee.website);
    }
}