public class Cample
{
    public double Factorial(int number)
    {
        if(number == 0)
        {
            return 1;
        }
        else
        {
            return number*Factorial(number - 1);
        }
    }
}

public class RecursionProgram
{
    public static void RMain()
    {
        // Recursion is method which call itself to compute a specific mathematic equation i.e factorial.

        Cample c1 = new Cample();
        Console.WriteLine(c1.Factorial(5));
    }
}