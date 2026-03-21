public class Prcogram
{
    // Check before parsing and avoid exception.
    public static void Mcain()
    {
        string s;
        Console.WriteLine("Enter a number: ");
        s = Console.ReadLine();

        bool b = int.TryParse(s, out int n);
        if (b)
        {
            Console.WriteLine("Conversion is successful");
        }
        else
        {
            Console.WriteLine("Conversion not successful");
        }
    }
}