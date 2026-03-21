namespace Inheritance
{
    public class Employee
    {
        // fields
        private int _empID;
        private string _empName;
        private string _location;

        // properties
        public int EmpID
        {
            set
            {
                _empID = value;
            }
            get
            {
                return _empID;
            }
        }
        public string EmpName
        {
            set { _empName = value; }
            get { return _empName; }
        }
        public string Location
        {
            set { _location = value; }
            get { return _location; }
        }
    }

    public class Manager: Employee
    {
        private string _department;
        public string Department
        {
            set { _department = value; }
            get { return _department; }
        }

        public double TotalSalesYear()
        {
            return 50000;
        }
    }

    public class Salesman:Employee
    {
        private string _region;
        public string Region
        {
            set { _region = value; }
            get { return _region; }
        }

        public double TotalSalesMonth()
        {
            return 10000;
        }
    }



    // Main Class
    public class ProgramIx
    {
        public static void MainIx()
        {
            Employee e1 = new Employee();
            e1.EmpID = 100;
            e1.EmpName = "John";
            Console.WriteLine("Objects of Parent Class");
            Console.WriteLine("EmpId: " + e1.EmpID);
            Console.WriteLine("EmpName: " + e1.EmpName);

            Manager m1 = new Manager();
            m1.EmpID = 101;
            m1.EmpName = "Doe";
            m1.Department = "Manager";
            m1.Location = "USA";
            Console.WriteLine("\nObjects of Child Class Manager");
            Console.WriteLine("Manager EmpId: " + m1.EmpID);
            Console.WriteLine("Manager EmpName: " + m1.EmpName);
            Console.WriteLine("Manager Department: " + m1.Department);
            Console.WriteLine("Manager Location: " + m1.Location);
            Console.WriteLine("Manager Annual Sale: " + m1.TotalSalesYear());

            Salesman s1 = new Salesman();
            s1.EmpID = 102;
            s1.EmpName = "Scott";
            s1.Region = "South Asia";
            s1.Location = "Brazil";
            Console.WriteLine("\nObjects of Child Class Salesman");
            Console.WriteLine("Salesman EmpId: " + s1.EmpID);
            Console.WriteLine("Salesman EmpName: " + s1.EmpName);
            Console.WriteLine("Salesman Region: " + s1.Region);
            Console.WriteLine("Salesman Location: " + s1.Location);
            Console.WriteLine("Salesman Monthly Sale: " + s1.TotalSalesMonth());

        }
    }
}
