using NamedArgument;

public class NamedArgumentProgram
{
    public static void NamedArgumentMain()
    {
        NamedArg a1 = new NamedArg();
        a1.SetName(namedParam: "Raj Kumar");

        Console.WriteLine("My Name is: "+a1.GetName());
    }
}