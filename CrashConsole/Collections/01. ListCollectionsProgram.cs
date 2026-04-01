/* Collections: Collections are the standard way to store and manipulate group of elements 
   (primitive or objects) 

    Example: List Collection
    -Syntax
    List<type> referenceVariable = new List<type>();

    Note:
    1. Collections can store unlimited elements.
    2. You need not to specify the size of collections while creating.
    3. You can search, sort, copy collections using various built-in methods.
    
    ========LIST==========
    List: List contains a group of elements of same type. A List class is a generic class so you need to specify data type of value while creating object.
    
    -Syntax
    List<type> referenceVariable = new List<type>();
    
 */

public class LProgram
{
    public static void LMain()
    {
        // create refvariable
        List<int> myList;

        // create object of list class
        myList = new List<int>() { 10, 20, 30 }; 

        foreach (int i in myList)
        {
            Console.WriteLine(i);
        }
    }
}