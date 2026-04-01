/* Insert & InsertRange Methods: This method allows you to insert elements at specific index.

   Insert: Allows you to add single elememnt at specific index
   - List.Insert(int index, T Value);

   InsertRange: Allows you to add multiple values at specific index
   - List.InsertRange(int index, IEnumerable<T> newValue

*/

public class ProgramINS
{
    public static void MainINS()
    {
        // create reference variable for List class & create object of List class
        List<int> list = new List<int>() { 10, 20 , 30 };
        List<int> newList = new List<int>() { 40, 50, 60 };
        
        Console.WriteLine(list[1]);

        list.Insert(1, 30);  // Insert

        Console.WriteLine(list[1]+"\n");


        list.InsertRange(2, newList); // InsertRange , Output should be: 10, 20 , 40, 50, 60, 30
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

    }
}