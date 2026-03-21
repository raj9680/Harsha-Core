using RefReturns;
using System;

public class SyProgram
{
    public static void SyMain()
    {
        Class1 c1 = new Class1();
        ref int g = ref c1.DoWork();

        Console.WriteLine("Value of ref of Grade: "+g+ "\n");
        g = 7;
        Console.WriteLine("Value of ref of Grade: " + c1.grade);

        // g will contain the ref of grade variable.
    }
}