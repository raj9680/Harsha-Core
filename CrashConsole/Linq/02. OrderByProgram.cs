/*
    Linq: Linq is a 'uniform query syntax' that allows you to retrieve data from various 
    data sources such as arrays, collections, databases, XML files.
    
    List.OrderBy()
    
    -syntax:
    var result = List.Where(temp => temp.Location == 'New York').ToList();
    // returns a list of customers from New York location.

*/
namespace CrashConsole.Linqq
{
    public class Employeee
    {
        public int empID { get; set; }
        public string? empName { get; set; }
        public string? countryName { get; set; }
    }

    public class ProgramOB
    {
        public static void MainOB()
        {
            List<Employeee> employeees = new List<Employeee>()
            {
                new Employeee { empID=100, empName="Ana", countryName="USA" },
                new Employeee { empID=101, empName="John", countryName="Canada" },
                new Employeee { empID=102, empName="Doe", countryName="Italy" },
                new Employeee { empID=103, empName="Max", countryName="USA" },
            };

            // LINQ - 1 () -- sort in ASC
            var emp = employeees.OrderBy(em => em.countryName);

            // var emp = employeees.OrderByDescending(em => em.countryName); -- for desc

            // var emp = employeees.OrderBy(em => em.countryName).ThenBy(em => em.empName); -- if any value is same then sort by empName.

            foreach (var employee in emp)
            {
                Console.WriteLine(employee.empName);
            }
        }
    }
}
