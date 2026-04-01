/* IndexOf: There are various pre-defined methods of arrays.

   IndexOf
    -Syntax
    Array.IndexOf(array, value, startIndex);

    -Example
    Array.IndexOf(a, value3, 0)

 */

public class InProgram
{
    public static void InMain()
    {
        int[] arrRef = new int[6] { 30, 30, 30, 40, 50, 60 }; 

        //search 3 in array - bydefault search will start from index 0
        Array.IndexOf(arrRef, 3); // if found return Index &if not found return -1

        //search 3 in array - search will start from index 2
        Array.IndexOf(arrRef, 3); // if found return Index &if not found return -1

        Array.IndexOf(arrRef, 30, 2);

       
    }
}