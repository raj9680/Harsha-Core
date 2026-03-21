using ParameterModifiers;

public class DefaultProgram
{
    public static void DefaultMain()
    {
        ParaModifiers p1 = new ParaModifiers();
        string name = "RAJ";
        Console.WriteLine(p1.Default(name));
        Console.WriteLine("\nThe original value of argument is not affected: " + name);
    }
}