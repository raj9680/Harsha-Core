// Interfaces: Interfaces are also like abstract classes but interfaces only have abstract methods which are must for child classes to inherit
// (unlike abstract classes have both abstract + normal methods) 
// Interface methods are by default- "public" and "abstract"
// Cannot create obj. of interface.
// Interface class cannot have a parent class. i.e interface cannot inherit any other class.

namespace Interface
{
    public interface IEmployee
    {
        // auto properties
        public int empID { get; set; }
        public string empName { get; set; }

        // abstract methods
        string GetHealthInsuranceAmount();
    }

    public class Student : IEmployee
    {
        private int _empID;
        public int empID
        {
            set { _empID = value; }
            get { return _empID; }
        }

        private string _empName;
        public string empName
        {
            set { _empName = value; }
            get { return _empName;  }
        }

        public string GetHealthInsuranceAmount()
        {
            return "This is abstract method implemented in child class from interface";
        }
    }


    public class Program_
    {
        public static void Main_()
        {
            IEmployee e1 = new Student();
            e1.empID = 100;
            e1.empName = "RAJ";
            Console.WriteLine(e1.empID);
            Console.WriteLine(e1.empName);
        }
    }
}



