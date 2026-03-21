public class Employee
{
    // instance field - always pvt.
    private string _empName;

    // instance property 'EmpName' of '_empName' field
    public string EmpName
    {
        set { _empName = value; }
        get { return _empName; }
    }


    // static field - always pvt.
    private static string _companyName;

    // static property 'CompanyName' of '_companyName' field
    public static string CompanyName
    {
        set 
        { 
            if(value.Length > 0) // we can do validation in properties
            {
                _companyName = value;
            }
        }

        get { return _companyName; }
    }
}


public class oProgram
{
    public static void oMain()
    {
        Employee e1 = new Employee();
        e1.EmpName = "Raj Kumar";
        Console.WriteLine("Name is: "+e1.EmpName);

        Employee.CompanyName = "Microsoft";
        Console.WriteLine("Company Name is: "+Employee.CompanyName);
    }
}