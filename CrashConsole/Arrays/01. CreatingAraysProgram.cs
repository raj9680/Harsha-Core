/* Array: Array is a group of values of same data type.

   Points to remember:
   1. Arrays are stored in continuous-memory-location in heap.

   Example: 

   -Syntax
    type[] arrayRefVariableName = new type[size];

 */

public class ArrProgram
{
    public static void ArrMain()
    {
        int[] a = new int[4] { 1, 2, 3, 4 }; // int tyoe array
        string[] b = new string[3] { "Name", "Age", "DOB"}; // string type array

        for (int i = 0; i< a.Length; i++)
        {
            Console.WriteLine("Each value of int type array: "+a[i]);
            if(i < 3)
            {
                Console.WriteLine("Each value of string type array: " + b[i]+"\n");
            }
            
        }

        // using foreach
        foreach (int i in a)
        {
            Console.WriteLine("ForEach value of int type array: " + i+"\n");
        }

        // reverse loop
        for(int i = a.Length-1; i>=0; i--)
        {
            Console.WriteLine(a[i]);
        }
    }
}