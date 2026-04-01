/* List Methods: List has various pre-built methods.
    
   Add(T): Allows you to only a single element to add in one go.
       Example:
       listRef.Add(value);

   AddRange(IEnumerable<T>): Allows you to add multiple elements to a collections in one go.
       Example:
       
*/

public class ProgramAd
{
    public static void MainAd()
    {
        List<int> myList = new List<int>() { 10, 20, 30 };
        List<int> otherList = new List<int> { 70, 80, 90 };

        // only sungle value can be added
        myList.Add(40); // output 10, 20 , 30 , 40

        // for adding multiple value
        myList.AddRange(otherList); // output 10, 20 , 30 , 40 , 70, 80 , 90

        foreach (int i in myList)
        {
            Console.WriteLine(i);
        }

    }
}