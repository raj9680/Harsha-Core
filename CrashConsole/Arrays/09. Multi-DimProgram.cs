/* Multi-Dimentional Arrays: Group of multiple rows contains a group of values.
 * 
                C0         C1
    Row[0]  { Value1,   Value2 }
    Row[1]  { Value1,   Value2 }
    Row[2]  { Value1,   Value2 }
    Row[3]  { Value1,   Value2 }
    Row[4]  { Value1,   Value2 }

    Note:
    1. Stores element in rows & columns.
    2. Every row contains a series of elements.
    3. You can create two or more dimentions, by increasing the no. of commas (,).
    
    Syntax:
    type[,] arrayReferenceName = new type[rowSize, columnSize]; // one , for two-dim, two , for three-dim etc...


 */

public class ProgramDim
{
    public static void MainDim()
    {
        int[,] a = new int[3, 2]
        {
            { 10, 20 },
            { 40, 50 },
            { 60, 70 },
        };

        for (int i = 0; i < 3; i++)
        {
            for(int j = 0;  j < 2; j++)
            {
                Console.Write(a[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}