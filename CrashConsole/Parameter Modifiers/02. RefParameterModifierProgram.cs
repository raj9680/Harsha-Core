using RefParameterModifier;
using System.Diagnostics;

public class RefParameterModifierProgram
{
    public static void RefParameterModifierMain()
    {
        RefParam r1 = new RefParam();
        string name = "Name";
        r1.RefModifier(ref name);
        Console.WriteLine(name);
    }
}