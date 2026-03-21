/* Boxing and Unboxing --- Very Important
 * 1. Boxing:    Is a conversion from Value-type to Reference-type.
      example: int ---> System.Object

 * 2. Un-Boxing: Is a conversion from Reference-type to Value-type.
      example: System.Object ---> int

  Note: There is no specific syntax, it happen automatically internally.
*/

public class BoxProgram
{
    public static void BoxMain()
    {
        // primitive variable
        int x = 10;     // stack

        // boxing (value-typeto reference type)
        object obj = x;     // heap


        // Note: if the value have been copied form heap to stack is called un-boxing & if the value have been copied form stack to heap is called boxing

        Console.WriteLine(x); // Output: 10
        Console.WriteLine(obj); // Output: 10
    }
}