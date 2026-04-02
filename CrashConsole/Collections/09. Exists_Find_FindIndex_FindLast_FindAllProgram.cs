/*
    Methods: 
    1. Exists: This method executes the lambda expression once per each element. It returns true 
       if ateast one elements matches with the given condition; but returns false;, if not elements
       matches with the given condition.
       ex: List.Exists(Predicate<T>);
           List.Exists(n => n > 15);

    2. Find: This method executes the lambda expression once per each element. It returns value of 
       first matching element, if not found any element then it return default value based on dataType.
       ex: List.Find(Predicate<T>);
           List.Exists(n => n > 15);

    3. FindIndex: This method executes the lambda expression once per each element. It returns Index of first matching element, if not found any element then it return default value -1.
       ex: List.FindIndex(Predicate<T>);
           List.FindIndex(n => n > 15);

    4. FindLast: This method executes the lambda expression once per each element. It returns value of 
       last matching element, if not found any element then it return default value of dataType.
       ex: List.FindLast(Predicate<T>);
           List.FindLast(n => n > 15);

    5. FindAll: This method executes the lambda expression once per each element. It returns all values which matching the condition. But return empty collection if no matching elements.
       ex: List.FindAll(Predicate<T>);
           List.FindAll(n => n > 15);

*/

public class ProgramFind
{
    public static void MainFind()
    {
        List<int> list = new List<int>() { 1, 3, 4, 6, 3 };
        bool a = list.Exists(n=> n > 2);        //  true                 ===== Exists
        int a1 = list.Find(n=> n > 2);          //    3                  ===== Find
        int a2 = list.FindIndex(n=> n > 3);     //    2                  ===== FindIndex
        int a3 = list.FindLast(n=> n > 2);      //    3                   ===== FindLast
        int a4 = list.FindLastIndex(n=> n > 2); //    4                   ===== FindLast

        List<int> a5 = new List<int>();
                  a5 = list.FindAll(n=> n > 2);    //    [3, 4, 6, 3]        ===== FindAll (List)
        // OR
        int[] arr = list.FindAll(n => n > 2).ToArray();    //  [3, 4, 6, 3]  ===== FindAll(Array)


        Console.WriteLine(a);
        Console.WriteLine(a1);
        Console.WriteLine(a2);
        Console.WriteLine(a3);
        Console.WriteLine(a4+"\n");

        foreach(int i in a5)
        {
            Console.WriteLine(i);
        }
    }
}
