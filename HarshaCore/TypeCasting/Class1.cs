using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Employee
{
    public int empId;
    public string empName;
    public string job;
    public static string website;

    // instance constructor
    public Employee(int eId, string eName, string Job)
    {
        this.empId = eId;
        this.empName = eName;
        this.job = Job;
    }

    // static constructor
    static Employee()
    {
        website = "https://example.com/";
    }
}