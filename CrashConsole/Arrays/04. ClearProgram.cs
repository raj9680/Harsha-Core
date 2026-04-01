/* Clear: This methods starts with the given index and sets all the 'length' no. of elements to zero (0).

   Clear():
    -Syntax
    Array.BinarySearch(arrayRef, index, length);
    arrayRef: array
    index: from where to start
    length: no. of elements you want to set 0

    -Example
    Array.BinarySearch(a, 2, 4)

 */

public class ProgramCL
{
    public static void MainCL()
    {
        int[] arrRef = new int[6] { 10, 20, 30, 40, 50, 60 };

        //clear elements of array
        Array.Clear(arrRef, 0, arrRef.Length);   // all elements go 0 ie. 0 0 0 0 0 0
        Array.Clear(arrRef, 2, 3);   // output: 10 20 0 0 0 60 i.e starting from 2 and no. of elemnts from 2 is 3

        // dislay array
        foreach (int i in arrRef)
        {
            Console.WriteLine(i);
        } 
    }
}