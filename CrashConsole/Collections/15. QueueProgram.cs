/* 
    Queue: Queue collection conatins a group of elements based on FIFO (First-In-First-Out) based 
    collection.
    
    Note: 
    1. Firstly added items at front.
    1. Lastly added items at rear.
    
    Syntax: 
    Queue<T> refVar = new Queue<T>();
    
    Example:
    Stack<T> refVar = new Stack<T>();
    refVar.Enqueue(); // for adding value
    refVar.Dequeue();  // for removing value
    refVar.Peek();  // it will return last element but not remove

    NOTE: IN CASE OF STACK OR QUEUE, VALUES CANNOT BE ADDED IN THE MIDDLE. 
 */

public class QueueStudent
{
    public int Marks { get; set; }
    public string? Rank { get; set; }
}

public class ProgramQ
{
    public static void MainQ()
    {
        Queue<int> queueList = new Queue<int>();
        queueList.Enqueue(1);
        queueList.Enqueue(3);
        queueList.Enqueue(2);
        queueList.Enqueue(5);

        foreach(int i  in queueList)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nElement removed is: "+queueList.Dequeue());
    }
}