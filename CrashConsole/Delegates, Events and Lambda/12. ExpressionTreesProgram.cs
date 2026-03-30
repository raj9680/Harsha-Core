/* Expression Trees: Expression trees is a collection of delegates represented in tree-like   
   structure. 

    Note: 
    1. Expression tree only execute whenever we compile and execute it.
    2. Expression Trees supports all types of delegates such as Func, Action, Predicate or custom 
       delegate types.

    Example:

    Syntax-
    Expression <Func<type1, type2, ...>> referenceVariable;
    
    Compile and Excute-
    Func<type1, type2, ...> referenceVariable2 = referenceVariable.Compile();
    referenceVariable2.Invoke(arg1, arg2, ...);
 
 */


using System.Linq.Expressions;

public class Studentts
{
    public int StudentID { get; set; }
    public int StudentAge { get; set; }
    public string? StudentName { get; set; }
}
public class ExpProgram
{
    public static void ExpMain()
    {
        Studentts s = new Studentts() { StudentID = 101, StudentAge = 24, StudentName = "Scott" };

        // create expression tree with Func
        Expression<Func<Studentts, bool>> expression = s1 => s1.StudentAge > 20;

        // Compile expression using compile method to invoke it as Delegate
        Func<Studentts, bool> myDelegate = expression.Compile();

        // Execute the method
        bool result = myDelegate.Invoke(s);

        Console.WriteLine(result);
    }
}