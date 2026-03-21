// Auto-Implemented properties: Properties without definition of set and get accessors.
public class Employe
{
    // Raw Prop.
    private int _empId;
    public int EmpId
    {
        get { return _empId; }
        set { _empId = value; }
    }

    public string EmpName { get; set; } // auto-implemented prop. with both read and write operation we can perform.

    public int Age { get; } // // auto-implemented prop. only readonly.
    // public int Marks { set; } // // auto-implemented prop. writeonly.

    public string Category { get; } = "General"; // Auto-Implemented property with Initializer
}

public class Programx
{
    public static void Mainx()
    {
        Employe e1 = new Employe();
        e1.EmpName = "RAJ";
        Console.WriteLine(e1.EmpName);
    }
}