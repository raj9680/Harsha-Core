using OurParameterModifier;

public class OutProgram
{
    public static void OutMain()
    {
        Class1 c1 = new Class1();
        string name;
        string val = c1.OutParamModifier(out name);
        Console.WriteLine("First value: "+name+ "\nSecond value: "+ val);
    }
}