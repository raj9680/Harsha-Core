/*

    Methods: 
    1. ToArray: This method is used to converts the collection into an array with same elements.
       ex: List.ToArray();

    2. Foreach: This method executes the lambda expression once per each element.
       ex: List.ForEach( n => {Console.WriteLine(n);} );

*/

class Testing
{
    public List<int> TestMethod(int[] a)
    {
        List<int> l1 = new List<int>();

        foreach (var item in a)
        {
            l1.Add(item);
        }
        return l1;
    }
}
public class ProgramSS
{
    public static void MainSS()
    {
        Testing T1 = new Testing();

        List<int> list = new List<int>() { 1, 3, 4, 6, 5 };
        int[] arr = list.ToArray();                          // ToArray Method

        List<int> newList = T1.TestMethod(arr);

        // Foreach
        newList.ForEach(item => Console.WriteLine(item));   // Forach() Method
    }
}
