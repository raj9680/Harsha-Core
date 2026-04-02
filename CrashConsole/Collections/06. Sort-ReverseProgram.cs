/*

    Methods: 
    1. Sort: This method is used to sort the data in a collection.
       ex: List.Sort();

    2. Reverse: This method is used to reverse the data in a collection.
       ex: List.Reverse();

*/

public class ProgramSort
{
    public static void MainSort()
    {
        List<int> list = new List<int>() { 1, 3, 4, 6, 5 };
        list.Sort(); // data sorted
        list.Reverse(); // And reversed so output should be 6 5 4 3 2 1
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
}
