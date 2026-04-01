/* Jagged Arrays: Array of Arrays

                C0         C1
    Row[0]  { Value1,   Value2 }
    Row[1]  { Value1,   Value2, Value3 }
    Row[2]  { Value1,   Value2, Value4, Value5 }
    Row[3]  { Value1,   Value2 }
    Row[4]  { Value1,   Value2, Value3 }

    Note:
    1. Jagged Array is an array of arrays.
    2. The member arrays can be of any size.
    
    Syntax:

    type[][] arrayReferenceName = new type[rowSize][];

    arrayReferenceName[index] = new type[size];

 */

public class ProgramJ
{
    public static void MainJ()
    {
        int[][] a = new int[4][];

        a[0] = new int[3] {1, 2, 3};
        a[1] = new int[2] {4, 5};
        a[2] = new int[4] {6, 7, 8, 9};
        a[3] = new int[3] {10, 11, 12};

        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}