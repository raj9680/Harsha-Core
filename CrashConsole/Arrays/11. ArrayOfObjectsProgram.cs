/* Array of Objects: An array which stores obj of same types. */

public class EmployeeQ
{
    public string EmpName { get; set; }
    public int EmpAge { get; set; }
}

public class ProgramArr
{
    public static void MainArr()
    {
        EmployeeQ emQ = new EmployeeQ() { EmpName = "John", EmpAge = 20 };
        EmployeeQ emQ1 = new EmployeeQ() { EmpName = "Scott", EmpAge = 21 };
        EmployeeQ emQ2 = new EmployeeQ() { EmpName = "Doe", EmpAge = 23 };

        EmployeeQ[] emQArray = new EmployeeQ[] { emQ, emQ1, emQ2 };

        foreach (var item in emQArray) 
        {
            Console.WriteLine(item.EmpName + " : " + item.EmpAge);
        }
    }
}