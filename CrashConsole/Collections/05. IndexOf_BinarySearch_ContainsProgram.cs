/*

    Methods: 
    1. IndexOf(T value): This method searches for collection for given value. If value find its Index is returned else             -1 index is returned.
       ex: List.IndexOf(T value);

    2. IndexOf(T value, int index): This method searches for collection for given value starting from specific index. If value 
                  find its Index is returned else -1 index is returned.
       ex: List.IndexOf(T value, int index);

    3. BinarySearch(T value): This method is used to search in large sorted collection.
       ex: List.BinarySearch(T value);

    4. Contains(T value): Returns True or false of if value found.

*/

public class ProgramBins
{
    public static void MainBins()
    {
        List<string> list = new List<string>() { "Name1", "Name1", "Name3", "Name4" };
        int a = list.IndexOf("Name3"); // Index of Name1 should be returned i.e. 2
        int a1 = list.IndexOf("Name3", 1); // Index of Name1 should be returned i.e. 2, it will still return original index

        // bool ifFound = list.Contains("Name1");
        //if (ifFound)
        //{
        //    Console.WriteLine("Name1 found");
        //}

        Console.WriteLine(a);
        Console.WriteLine(a1);
    }
}
