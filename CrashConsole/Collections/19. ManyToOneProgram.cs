/*
    Object Relations: ManyToOne
   
 * 
 */

public class Department
{
    public int DepartmentID { get; set; }
    public string? DepartmentName { get; set; }
}

public class Employi
{
    public int EmployeeID { get; set; }
    public string? EmployeeName { get; set; }
    public string? EmployeeEmail { get; set; }
    public Department? Dept { get; set; }
}

public class ProgramM
{
    public static void MainM()
    {
        // Employi obj enitialisation
        Employi employi0 = new Employi();
        Employi employi1 = new Employi();
        Employi employi2 = new Employi();

        // Department obj initialisation
        Department dept0 = new Department() { DepartmentID = 001, DepartmentName = "Engineering"};
        Department dept1 = new Department() { DepartmentID = 002, DepartmentName = "Accountancy"};


        // Employee 1
        employi0.EmployeeID = 21;
        employi0.EmployeeName = "Rohan";
        employi0.EmployeeEmail = "rohan@email.com";
        employi0.Dept = dept0;

        // Employee 2
        employi1.EmployeeID = 22;
        employi1.EmployeeName = "Ronit";
        employi1.EmployeeEmail = "ronit@email.com";
        employi1.Dept = dept1;

        // Employee 2
        employi2.EmployeeID = 23;
        employi2.EmployeeName = "Monit";
        employi2.EmployeeEmail = "monit@email.com";
        employi2.Dept = dept1;

        // Read Details
        Console.WriteLine($"Employee ID: {employi0.EmployeeID}, Employee Name: {employi0.EmployeeName}, Email: {employi0.EmployeeEmail}, Department ID: {dept0.DepartmentID}, Department Name: {dept0.DepartmentName}\n");

        Console.WriteLine($"Employee ID: {employi1.EmployeeID}, Employee Name: {employi1.EmployeeName}, Email: {employi1.EmployeeEmail}, Department ID: {dept1.DepartmentID}, Department Name: {dept1.DepartmentName}\n");

        Console.WriteLine($"Employee ID: {employi2.EmployeeID}, Employee Name: {employi2.EmployeeName}, Email: {employi2.EmployeeEmail}, Department ID: {dept1.DepartmentID}, Department Name: {dept1.DepartmentName}\n");

    }
}