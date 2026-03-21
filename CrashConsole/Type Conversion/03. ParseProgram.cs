public class PrProgram
{
    // string to numerical type i.e string -> int
    // Condition: The source value must contain digits only; shouldnt   contain spaces, alphabets or special characters.

    // Syntax: DestinationDateType.Parse(SourceValue)
    public static void PrMain()
    {
        // string
        string a = "100";

        // int
        int b = int.Parse(a);

        Console.WriteLine(a); // Output: "100"
        Console.WriteLine(b); // Output: 100
    }
}