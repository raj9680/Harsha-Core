public class Student
{
    public int grade = 2;

    public void PrintGrade()
    {
        Console.WriteLine("Grade: "+grade);
    }

    // public method with ref return
    public ref int DoWork()
    {
        return ref grade;
    }
}