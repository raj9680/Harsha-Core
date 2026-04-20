/*  
    ElementAt(): It will return the Element found at given Index.
    ElementAtOrDefault(): It will return the element found at given Index or if not found 
    it will return null. Better for avoiding exception.
    
    List.ElementAt()
    List.ElementAtOrDefault()
    
    -syntax:
    var result = List.ElementAt(temp => temp.Location == 'New York').ToList();
    var result = List.ElementAtOrDefault(temp => temp.Location == 'New York');
    
*/

namespace CrashConsole.Linqsq
{
    public class Employeee
    {
        public int empID { get; set; }
        public string? empName { get; set; }
        public string? countryName { get; set; }
    }

    public class ProgramEA
    {
        public static void MainEA()
        {
            List<Employeee> employeees = new List<Employeee>()
            {
                new Employeee { empID=100, empName="Ana", countryName="USA" },
                new Employeee { empID=101, empName="John", countryName="Canada" },
                new Employeee { empID=102, empName="Doe", countryName="Italy" },
                new Employeee { empID=103, empName="Max", countryName="USA" },
            };

            // LINQ
            Employeee emp = employeees.ElementAt(2);
            // Employeee emp = employeees.ElementAtOrDefault(2);

            // Employeee emp = employeees.LastOrDefault(em => em.countryName == "USA");

            if (emp != null)
            {
                Console.WriteLine(emp.empName);
            }
        }
    }
}
