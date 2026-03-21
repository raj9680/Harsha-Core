// 'base' keyword: Accessing parent's class member in child class. (when name "ambiguity" b/w parent and child class's member & child class member)
public class Teachers
{
    public string Department { get; set; }
}

public class Students: Teachers
{
    public string Department { get; set; }

    // Method
    public string Student()
    {
        Department = "This is Student Department";
        base.Department = "This Teachers Department";
        return this.Department + "\n" + base.Department;
    }
}

public class BProgram
{
    public static void BMain()
    {
        Students s1 = new Students();
        Console.WriteLine(s1.Student());
    }
}