/*

    Methods: 
    1. ConvertAll: This method executes the lambda expression once per each element. It adds each 
       returned element into a new collection and returns the same at last; thus it converts all 
       elements from the input collection as output collection.
       
       Syntax:
       List<TOutput> List.ConvertAll(Convert<TInput, TOutput>);

       Example:
       List.ConvertAll(n => Convert.ToDouble(n));
    
*/


public class ProgramCv
{
    public static void MainCv()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4};

        List<string> list2 = list.ConvertAll<string>((x) =>
        {
            string word;
            switch (x)
            {
                case 1: word = "One"; break;
                case 2: word = "Two"; break;
                case 3: word = "Three"; break;
                case 4: word = "Four"; break;
                default:  word = ""; break;
            }
            return word;
        });

        // OR
        // List<string> list1 = list.ConvertAll(x => Convert.ToString(x));

        foreach (var item in list2)
        {
            Console.WriteLine(item);
        }
    }
}
