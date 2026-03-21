/* Generic Constraint: It is used to specify the types allowed to be accepted in the "generic type parameter".
 * 
  class ClassName<T> where T: class
  {
    public T FieldName;
  }

  where T: class
  where T: struct
  where T: ClassName
  where T: InterfaceName
  where T: new()
  
  ClassName<int> referenceVariable = new ClassName<int>(); // error
 
 */
namespace CrashConsole.Generics
{
    public abstract class Student
    {
        public abstract int Marks { get; set; }
    }

    public class GraduateStudents : Student
    {
        public override int Marks { get; set; }
    }

    public class PostGraduateStudent : Student
    {
        public override int Marks { get; set; }
    }


    // Main thing to understand
    // Generic class with constraints (want to accept Student or its derived classed only)
    public class MarksPrinter<T> where T : Student // only Student type paramter is suplied in this gen.
    {
        public T stu;
        public void PrintMarks()
        {
            Student temp = stu;
            Console.WriteLine(temp);
        }
    }



    public class GenConstraintProgram
    {
        public static void GenConstraintMain()
        {
            MarksPrinter<GraduateStudents> g1 = new MarksPrinter<GraduateStudents>();

            g1.stu = new GraduateStudents() { Marks = 70 };  // IMP

            // OR

            // g1.stu.Marks = 70; // this will cause null ref error bcz obj not created and value assign
            Console.WriteLine(g1.stu.Marks);
        }
    }
}
