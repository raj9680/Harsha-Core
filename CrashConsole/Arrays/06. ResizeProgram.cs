/* Resize: This methods increases/decreases size of array.

   Resize():
    -Syntax
        Array.Resize(ref arrayRef, newSize);
        arrayRef: array
        newSize: updated array size

    -Example
    Array.BinarySearch(ref a, 5)

 */

public class ProgramRes
{
    public static void MainRes()
    {
        int[] arrRef = new int[6] { 10, 20, 30, 40, 50, 60 };
        Console.WriteLine("Previous Size: " + arrRef.Length);

        Array.Resize(ref arrRef, 3);
        Console.WriteLine("After Resizing: " + arrRef.Length);
    }
}