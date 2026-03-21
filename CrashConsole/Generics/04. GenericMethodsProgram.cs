/* Generic Methods: Creating methods with generic-type parameters. Generic method is a method that has one or more generic parameters allow us to pass different types of value for the same parameter.

  Advantage: We can restrict which type of data type (class name) allowed to be passed while creating object or when we are unsure abt. which type of data type to pass than we can use this to make it flexible for multiple datatypes.
  
  Example:
    public void MethodName<>()
    {
        
    }

    // calling
    MethodName<datatype>(valueHere);
*/
namespace CrashConsole.Generics
{
    public class Employee
    {
        public int Salary { get; set; }
    }

    public class Student
    {
        public int Marks { get; set; }
    }

    public class Sample
    {
        public void PrintData<T>(T obj)
        // public void PrintData<T>(T obj) where T: class  // restricted to class type only
        {
            if (obj.GetType() == typeof(Student))
            {
                Student temp = obj as Student;
                Console.WriteLine(temp.Marks);
            }
            else if (obj.GetType() == typeof(Employee))
            {
                Employee temp = obj as Employee;
                Console.WriteLine(temp.Salary);
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Sample s1 = new Sample();

            Console.WriteLine("Student Type");
            Student stu = new Student() { Marks = 30 };
            s1.PrintData(stu);

            Console.WriteLine("\nEmployee Type");
            Employee emp = new Employee() { Salary = 300 };
            s1.PrintData(emp);
        }
    }
}