/*  
    Deep Copy: Deep copy, copies source object to desitination as a new object so 
    whenever any change happens in source or destination object it does not effects the 
    each others values or object. Both remains independent.
    
    Example: Below is the manual representation of performing Deep Copy.

*/
namespace CrashConsole.Arrays
{
    public class Employee : ICloneable // Interface
    {
        public string? EmployeeName { get; set; }
        public string? Role { get; set; }

        public object Clone() // Interface method
        {
            Employee new_one = new Employee() { EmployeeName = EmployeeName, Role = Role };
            return new_one;
        }
    }

    // Program
    public class ProgramDc
    {
        public static void MainDc()
        {
            Employee[] employee = new Employee[]
            {
                new Employee() { EmployeeName = "Joseph", Role = "Developer"},
                new Employee() { EmployeeName = "Jack", Role = "Designer"},
                new Employee() { EmployeeName = "Alexa", Role = "Analyst"}
            };

            Employee[] newDeepCopy = new Employee[employee.Length];

            for (int i = 0; i < employee.Length; i++)
            {
                var result = (Employee)employee[i].Clone();
                newDeepCopy[i] = result;
            }

            employee[1] = new Employee() { EmployeeName = "Rohit", Role = "Admin" };
            Console.WriteLine("Original Array Values");
            foreach (var item in employee)
            {
                Console.WriteLine(item.EmployeeName);
            }

            Console.WriteLine("\nValues in Deep Copy");
            foreach (var item in newDeepCopy)
            {
                Console.WriteLine(item.EmployeeName);
            }
        }
    }
}
