/* Predicate: Is a pre-defined delegate, which can be used to create events quickly similar to Func.
    
   Note: Difference b/w Func, Action & Predicate

         1. Func must have return value of any type; Action don't have return value; Predicate must have return value of 'bool' type.

         2. Func can have 0 - 16 parameters of any type. Action can have 0-16 paramaters of of any type. But Predicate must have only one paramtere of any type.

    Example: Creating Delegate based on Predicate
            
             public Predicate<Param1DataType> referenceVariable;
    
 */

public class Publisher
{
    public event Predicate<int>? myEvent;
    public bool RaiseEvent(int a)
    {
        return true;
    }
}

public class PreProgram
{
    public static void MainPre()
    {
        Publisher publisher = new Publisher();
        publisher.myEvent += (a) => true;

        publisher.RaiseEvent(1);
        publisher.RaiseEvent(2);
    }
}