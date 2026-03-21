using InParameterModifier;

public class PProgram
{
    public static void MMain()
    {
        InParam p1 = new InParam();
        string n = "RAJ";
        p1.InParamModifier(in n);
        Console.WriteLine(n);
    }
}