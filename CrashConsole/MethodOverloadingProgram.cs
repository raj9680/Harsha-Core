using MethodOverloading;
using System.Diagnostics;

public class OverloadingProgram
{
    public static void OverloadingProgramMain()
    {
        Overloading o1 = new Overloading();
        Console.WriteLine("Default: \n"+o1.Method());
        Console.WriteLine("\nDynamic: \n"+o1.Method(o1.Name="John Doe", o1.Age=30));
    }
}