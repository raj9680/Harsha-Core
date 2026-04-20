/* 
    Object Relations: An object can contain a field that stores references to one or more objects.
    
    Syntax: One to One Relation

*/

namespace CrashConsole.Collections
{
    public class Student
    {
        public int RollNo { get; set; }
        public string? StudentName { get; set; }
        public string? Email { get; set; }
        public Branch Branch { get; set; } // Contains reference to object of Branch class, that represents the branch that the current student belongs to.
    }

    public class Branch
    {
        public string BranchName { get; set; }
        public int NoOfSemesters { get; set; }
    }


    public class Program1
    {
        public static void Main1()
        {
            Student student = new Student();
            student.RollNo = 3212;
            student.StudentName = student.StudentName;

            /* Branch class's object
            Branch br = new Branch();
            br.BranchName = "CSE";
            br.NoOfSemesters = 8;

            // One to one relation
            student.Branch = br; */

            // OR
            student.Branch = new Branch();
            student.Branch.BranchName = "CSE";
            student.Branch.NoOfSemesters = 8;

            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Branch.BranchName);

        }
    }
}