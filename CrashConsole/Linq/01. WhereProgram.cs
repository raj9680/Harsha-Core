/*
    Linq: Linq is a 'uniform query syntax' that allows you to retrieve data from various 
    data sources such as arrays, collections, databases, XML files.
    
    List.Where()
    
    -syntax:
    var result = List.Where(temp => temp.Location == 'New York').ToList();
    // returns a list of customers from New York location.

*/
namespace CrashConsole.Linq
{
    public class Employeee
    {
        public int empID { get; set; }
        public string? empName { get; set; }
        public string? countryName { get; set; }
    }

    public class ProgramW
    {
        public static void MainW()
        {
            List<Employeee> employeees = new List<Employeee>()
            {
                new Employeee { empID=100, empName="Ana", countryName="USA" },
                new Employeee { empID=101, empName="John", countryName="Canada" },
                new Employeee { empID=102, empName="Doe", countryName="Italy" },
                new Employeee { empID=103, empName="Max", countryName="USA" },
            };

            // LINQ - 2 () 
            var emp = employeees.Where(em => em.countryName == "USA");
            foreach (var employee in emp)
            {
                Console.WriteLine(employee.empName);
            }
        }
    }
}
