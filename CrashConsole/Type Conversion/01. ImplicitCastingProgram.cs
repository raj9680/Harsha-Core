public class XProgram
{
    // Type Conversion is the method to convert a value from one type to another.
    // Types:
    // 1. Implicit Casting (lower to higher numerical type i.e int -> double),
    // 2. Explicit Casting (higher to lower numerical type i.e double -> int),
    // 3. Parsing/TryParse (from string to numerical type),
    // 4. Conversion Methods (any primitive type to any primitive type)


    // Implicit Casting: converting from lower numerical type to higher numerical type is always automatic i,e compiler auto type caste these types of conversion. This is called implicit casting.
    public static void XMain()
    {
        sbyte a = 10;
        int b;

        // auto conversion of sbyte to int i.e Implicit Casting
        b = a;

        Console.WriteLine(a); // 10
        Console.WriteLine(b); // 10

        // Note: There is a specific table of Implicit Casting to follow.
        // Video: 76
    }
}