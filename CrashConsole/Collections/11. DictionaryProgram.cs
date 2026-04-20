/* 
    
    Dictionary: Dictionary collection contains a group of elements of key/value pairs.
    
    Syntax: 
    Dictionary<TKey, TValue> referenceVariable = new Dictionary<TKey, TValue>();
    
    Example:
    Dictionary<string, int> dictVariable = new Dictionary<string, int>();
    dictVariable.Add("English", 20);

 */

public class ProgramDic
{
    public static void MainDic()
    {
        Dictionary<string, int> dictVariable = new Dictionary<string, int>()
        {
            { "English", 30 },
            { "Science", 40 },
            { "Maths",   50 },
        };
        

        foreach (KeyValuePair<string, int> item in dictVariable)
        {
            if(item.Key == "Science")
            {
                dictVariable.Remove(item.Key);
            }
        }

        foreach (KeyValuePair<string, int> item in dictVariable)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}