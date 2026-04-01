/* Sort: This methods sorts the array in ascending order.

   Resize():
    -Syntax
        Array.Sort(arrayRef);
        arrayRef: array

    -Example
    Array.Sort(a)

 */

public class ProgramS
{
    public static void MainS()
    {
        int[] a = new int[] { 10, 20, 80, 40, 50, 60 };
        Array.Sort(a);
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}