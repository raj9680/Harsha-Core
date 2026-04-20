/*  
    Select(): It will return the Element found at given Index.
    
    List.ElementAt()
    List.ElementAtOrDefault()
    
    -syntax:
    var result = List.ElementAt(temp => temp.Location == 'New York').ToList();
    var result = List.ElementAtOrDefault(temp => temp.Location == 'New York');
    
*/

namespace CrashConsole.Linqws
{
    public class Employeee
    {
        public int empID { get; set; }
        public string? empName { get; set; }
        public string? countryName { get; set; }
    }

    public class MyPersonn
    {
        public string? PersonName { get; set; }
    }

    public class ProgramSe
    {
        public static void MainSe()
        {
            List<Employeee> employeees = new List<Employeee>()
            {
                new Employeee { empID=100, empName="Ana", countryName="USA" },
                new Employeee { empID=101, empName="John", countryName="Canada" },
                new Employeee { empID=102, empName="Doe", countryName="Italy" },
                new Employeee { empID=103, empName="Max", countryName="USA" },
            };

            // Conversion of Employeee Type object into MyPersonn Type object

            IEnumerable<MyPersonn> persons = employeees.Select(em => new MyPersonn() { PersonName = em.empName });

            foreach (MyPersonn person in persons)
            {
                Console.WriteLine(person.PersonName);
            }
        }
    }
}
