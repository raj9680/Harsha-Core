/* 
    One to Many Relation: 
    
    Syntax: One to Many Relation

*/

namespace CrashConsole.Collections
{
    public class Studentt
    {
        public int RollNo { get; set; }
        public string? StudentName { get; set; }
        public string? Email { get; set; }
        public List<Examination>? Examination { get; set; } 
        // Each student can have multiple exams
    }

    public class Examination
    {
        public string? ExamSubject { get; set; }
        public DateOnly ExamDate { get; set; }
    }


    public class ProgramO2
    {
        public static void MainO2()
        {
            Studentt student = new Studentt();
            student.StudentName = "Raj";
            student.Email = "email@email.com";
            student.RollNo = 522;

            student.Examination = new List<Examination>();
            student.Examination.Add(new Examination { ExamDate = new DateOnly(), ExamSubject = "English" });
            student.Examination.Add(new Examination { ExamDate = new DateOnly(), ExamSubject = "Maths" });
            student.Examination.Add(new Examination { ExamDate = new DateOnly(), ExamSubject = "Science" });

            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            foreach (var item in student.Examination)
            {
                Console.WriteLine("Exam Date:" + item.ExamDate + "Exam Name: " + item.ExamSubject);
            }
        }
    }
}