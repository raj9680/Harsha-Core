/* Garbage Collection: Garbage collection is the process of deleting the objects from memory, to  free-up memory; so the same memory can be re-used.
 * 
 * Generations in GC:
 * a. Generation 2: [Long-lived Generation] 
 * b. Generation 1: [Survival Generation]
 * c. Generation 0: [Short-lived Generation]
 * 
 * 
 * Types of Resources (Memory Units): There are two types of resources

 * 1. Managed Resources: The objects that are created by CLR are called as "Managed Resources". Memory allocation and de-allocation by CLR i.e means all objects are under the control of CLR.
   Objects under managed resources are deleted automatically before the end of the application.

 * 2. Un-managed Resources: The objects that are not under the control of CLR is called un-managed resources i.e these objects are Un-managed resources ex: file systems, database connections etc. Objects under un-managed resources not get deleted at the end of application so we need Dispose & Destructors.
 * 
 * Destructors: Clears un-managed resources just before deleting the object; i.e generally at he end of application execution.
 * 
 * Dispose: Clears un-managed resources after the specific task (work) is completed; so no need to wait till end of application execution.
 * 
 * Difference b/w Distructor and Dispose: Destructor will be automaticaly executed while Dispose we need to call.
 * 
 * exaple: Syntax Destructor:
 * 
 *  ~ClassName() 
 *  {
 *      // bosy here
 *  }
 * 
 * 
 */


// Demostrating Destructor

public class DestructorClass
{
    //constructor
    public DestructorClass()
    {
        // file & db connection logic here
        Console.WriteLine("File or Db is Opened");
    }

    //destructor
    ~DestructorClass()
    {
        // close connection of file & db connection here
        Console.WriteLine("File is Closed");
    }
}


public class Program_des
{
    public static void Main_des()
    {
        DestructorClass d1 = new DestructorClass();

    }
}