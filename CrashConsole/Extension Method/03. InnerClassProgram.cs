/* Inner class(Nested class): It is a class which is created in another class (outer class or containing class).
 * 
 * example:
 * 
 * class ClassName
 *  {
 *      class InnerClassName
 *      {
 *          // Members here
 *      }
 *  }
 *  
 *  Benefits of creating inner class is to keep all related or iterrelated classes are grouped     together at same place.
 *  
 *  Syntax to access inner class : OuterClass.InnerClass
 */


using System.Data.SqlTypes;

public class MyStudent
{
    public int SecureMarks;
    public int MaxMarks;
    public int Percentage;
}

// Outer class
public class MarksCalculation
{
    public int CalculatePercentage(MyStudent s)
    {
        CalculationHelper c1 = new CalculationHelper();

        Console.WriteLine("Calling inner class from outer class");
        
        s.Percentage = s.SecureMarks * c1.Multiply(4,5);
        return s.Percentage;
    }

    // Inner class
    class CalculationHelper
    {
        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}

public class ProgramPP
{
    public static void MainPP()
    {
        MyStudent s1 = new MyStudent() { SecureMarks = 100 };
        MarksCalculation m1 = new MarksCalculation();
        Console.WriteLine(m1.CalculatePercentage(s1));
    }
}

