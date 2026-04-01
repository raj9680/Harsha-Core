/* BinarySearch: There are various pre-defined methods of arrays.

   BinarySearch(): This method searches the array for the given value / BinarySearch
    -Syntax
    Array.BinarySearch(array, value);

    -Example
    Array.BinarySearch(a, value3)

 */

public class BinProgram
{
    public static void BinMain()
    {
        int[] arrRef = new int[6] { 30, 20, 20, 40, 50, 60 }; // array should be sorted

        //search 30 in array - first half
        int n = Array.BinarySearch(arrRef, 30);
        Console.WriteLine("30 is found at: " + n);

        //search 40 in array - second half
        int n2 = Array.BinarySearch(arrRef, 40);
        Console.WriteLine("40 is found at: " + n2);
    }
}