// Method Hiding: To hide parent class method by creating another method in the child class with the same name and the same parameters. The return can be different.
// Note: Parent class method can be available and can be called using parent class ref variable or from base keyword from the child class
// Note: Child class method can be called using child class ref. variable
// Note: When method hiding is done, calls through a child-typed reference execute the child method; calls through a base-typed reference execute the parent method
public class IAm
{
    public string mySalary()
    {
        return "Salary from IAm";
    }
}

public class IAmChild: IAm
{
    public new string mySalary()
    {
        return "Salary from IAmChild";
    }
}


public class Programi
{
   public static void Maini()
    {
        IAmChild a1 = new IAmChild();
        Console.WriteLine(a1.mySalary());

        IAm a2 = new IAm();
        Console.WriteLine(a2.mySalary());
    }
}

