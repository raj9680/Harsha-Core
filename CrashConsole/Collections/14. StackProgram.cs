/* 
    
    Stack: Stack collection conatins a group of elements based on LIFO (Last-In-First-Out) based 
    collection.
    
    Syntax: 
    Stack<T> refVar = new Stack<T>();
    
    Example:
    Stack<T> refVar = new Stack<T>();
    refVar.Push(); // for adding value
    refVar.Pop();  // for removing value
    refVar.Peek(); // it returns last element from stack but not remove it

    NOTE: IN CASE OF STACK OR QUEUE, VALUES CANNOT BE ADDED IN THE MIDDLE. 

 */

public class StackStudent
{
    public int Marks { get; set; }
    public string? Rank { get; set; }
}

public class ProgramStack
{
    public static void MainStack()
    {
        Stack<StackStudent> stack = new Stack<StackStudent>();
        stack.Push(new StackStudent() { Marks=70, Rank="Third"});
        stack.Push(new StackStudent() { Marks=80, Rank="Second"});
        stack.Push(new StackStudent() { Marks=90, Rank="First"});

        foreach(StackStudent i in stack)
        {
            Console.WriteLine($"Marks: {i.Marks} and Rank is: {i.Rank}");
        }
        /* output: Marks: 90 and Rank is: First
                   Marks: 80 and Rank is: Second
                   Marks: 70 and Rank is: Third
        */
    }
}