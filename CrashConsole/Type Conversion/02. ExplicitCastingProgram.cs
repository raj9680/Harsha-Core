public class ExplicitCastingProgram
{
    public static void ExMain()
    {
        int a = 10;
        float b;

        b = (float)a;

        // Disadv. of explicit casting is it is of loosy conversion

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}