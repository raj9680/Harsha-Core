/* Reverse: This method reverse the array
 * 
 * Syntax
 * Array.Reverse(array);
 * 
 */

public class ReProgram
{
    public static void ReMain()
    {
        int[] a = new int[] { 1, 2, 3, 4, 5 };

        Array.Reverse(a);
        foreach (int i in a)
        {
            Console.WriteLine(i);
        }
    }
}