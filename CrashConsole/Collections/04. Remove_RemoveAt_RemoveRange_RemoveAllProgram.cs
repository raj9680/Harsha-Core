/*

    Methods: 
    1. Remove: It is used to remove specified element from the collection.
       ex: List.Remove(T value);

    2. RemoveAt: It is used to remove the element from collection at specified index.
       ex: List.RemoveAt(int Index);

    3. RemoveRange: This method removes specified count of elements starting from the specified startIndex.
       ex: List.RemoveRange(1, 2);

                                    ==============IMPORTANT==============

    4. RemoveAll: This methods remove all the elements that are matching with given condition. You can write your condition in lamda expression of predicate type.

*/

public class ProgramRMM
{
    public static void MainRMM()
    {
        List<string> list = new List<string>() { "Name1", "Name1", "Name3", "Name4" };
        // list.Remove("Name1"); // Name1 value should be remove from list.
        // list.RemoveAt(2);     // Value at index 2 i.e Name3 should be remove from list.
        // list.RemoveRange(0, 2); // Value at Index 0 and 1 will be removed.

        List<int> list1 = new List<int> { 1, 2, 3, 4 };
        list1.RemoveAll(x => x < 3); // remove all elements from list based on condition.

        foreach (var item in list1)
        {
            Console.WriteLine(item);
        }
    }
}