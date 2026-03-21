// Initialize field of an Object without Constructor.
// Note: Object Initializer executes after execution of the constructor. It can't have any initialization logic.
public class ObjInitializer
{
    public string Name;
    public string Company;
}

public class ObjectInitializerProgram
{
    public static void FMain()
    {
        ObjInitializer o1 = new ObjInitializer() { Name = "Raj", Company = "KT" };
        Console.WriteLine(o1.Name +" " + o1.Company);
    }
}