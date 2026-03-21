// Unboxing: Un-Boxing: Is a conversion from Reference-type to Value-type. Only if they are compatible
// example : System.Object   --->  int

public class Profbgram
{
    public static void Mafbin()
    {
        // Reference type variable
        object obj = 10; // in heap

        // un-Boxing (reference type to value-type)
        int x = (int)obj; // stack

        // Note: if the value have been copied form heap to stack is called un-boxing & if the value have been copied form stack to heap is called boxing

        Console.WriteLine(obj); // Output: 10
        Console.WriteLine(x); // Output: 10
    }
}