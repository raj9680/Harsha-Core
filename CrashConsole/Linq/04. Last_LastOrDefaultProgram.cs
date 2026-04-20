/*
    Last(): It will return the Last found value based on condition.
    LastOrDefault(): It will return the Last found value or null based on condition. 
    Better for avoiding exception.
    
    List.First()
    List.FirstOrDefault()
    
    -syntax:
    var result = List.Last(temp => temp.Location == 'New York').ToList();
    var result = List.LastOrDefault(temp => temp.Location == 'New York');

*/
namespace CrashConsole.Linqs
{
    public class Employeee
    {
        public int empID { get; set; }
        public string? empName { get; set; }
        public string? countryName { get; set; }
    }

    public class ProgramOBI
    {
        public static void MainOBI()
        {
            List<Employeee> employeees = new List<Employeee>()
            {
                new Employeee { empID=100, empName="Ana", countryName="USA" },
                new Employeee { empID=101, empName="John", countryName="Canada" },
                new Employeee { empID=102, empName="Doe", countryName="Italy" },
                new Employeee { empID=103, empName="Max", countryName="USA" },
            };

            // LINQ
            Employeee emp = employeees.Last(em => em.countryName == "USA");

            // Employeee emp = employeees.LastOrDefault(em => em.countryName == "USA");

            if (emp != null)
            {
                Console.WriteLine(emp.empName);
            }
        }
    }
}
