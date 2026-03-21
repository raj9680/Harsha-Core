public class TypeConversion
{
    /* Four Techniques of Type Casting
     * 1. Implicit Casting
     * 2. Explicit Casting
     * 3. Parsing / TryParse
     * 4. Conversion Methods
     */
    public static void MainT()
    {
        // Implicit
        int a = 1;
        double b = a;
        Console.WriteLine(b); // auto Implicit Casting

        // Explicit
        float c = (float)b;
        Console.WriteLine(c); // Explicit Casting

        // Parse
        string x = "100";
        int y;
        y = int.Parse(x);
        Console.WriteLine(x); // Output 100 as string
        Console.WriteLine(y); // Output 100 as int

        // Try Parse
        // read users input value
        string s;
        Console.WriteLine("Enter a number: ");
        s = Console.ReadLine();

        bool bb = int.TryParse(s, out int n);

        if (bb == true)
        {
            Console.WriteLine("Conversion Successful\n");
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("Conversion Failed");
        }

        // conversion method
        Convert.ToInt32(s); // s to be numeric - conversion method
    }
}