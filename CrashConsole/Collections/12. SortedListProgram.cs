/* 
    
    SortedList Collection: SortedListCollection containes group of elements in key/value pairs but 
    in sorted order.
    
    Syntax: 
    Dictionary<TKey, TValue> referenceVariable = new Dictionary<TKey, TValue>();
    
    Example:
    SortedList<string, int> sortedValueRef = new SortedList<string, int>();
    sortedValueRef.Add("English", 20);

 */

public class ProgramSl
{
    public static void MainSL()
    {
        SortedList<string, int> sortVariable = new SortedList<string, int>()
        {
            { "English", 30 },
            { "Science", 40 },
            { "Maths",   50 },
        };
        sortVariable.Add("Geography", 60);

        // search for speciic key
        bool k = sortVariable.ContainsKey("English");   // true

        // search for specific value
        bool n = sortVariable.ContainsValue(30);       // true

        // get index of specific key
        int o = sortVariable.IndexOfKey("Maths");     // 2

        // get index of specific Value
        int p = sortVariable.IndexOfValue(40);       // 2

        foreach (KeyValuePair<string, int> item in sortVariable.ToList())
        {
            if (item.Key == "Science")
            {
                sortVariable.Remove(item.Key);
            }
        }

        foreach (var item in sortVariable)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }

    }
}