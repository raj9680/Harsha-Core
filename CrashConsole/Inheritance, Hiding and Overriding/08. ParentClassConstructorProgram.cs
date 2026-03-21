// Accessing parent class ctor from child class or more. using base
// Note: It is optional to call "Parent" class's parameter less ctor fro child class.
// Note: It is must to call parent class's parameterized ctor from child class and pass necessary argument.


public class EmpClass
{
    public int EmpID { get; set; }
    public string EmpName { get; set; }

    public EmpClass(int empID, string empName)
    {
        this.EmpID = empID;
        this.EmpName = empName;
    }
}

public class EmpStudent: EmpClass
{
    public string Department { get; set; }
    public EmpStudent(int EmpID, string EmpName, string Department):base(EmpID, EmpName)
    {
        this.Department = Department;
    }
}


public class Pregram
{
    public static void Mein()
    {
        EmpStudent e1 = new EmpStudent(101, "RAJ", "Engineering");
        Console.WriteLine("EmpId is: "+e1.EmpID+"\n"+"EmpName is: "+e1.EmpName+"\n"+"Emp Department is: "+e1.Department);
    }
}