public class Student
{
    // To pass multiple paramaters or params in one parameter
    public void DisplaySubject(params string[] subjects)
    {
        foreach (var item in subjects)
        {
            Console.WriteLine(item);
        }
    }
}

public class NProgram
{
    public static void NMain()
    {
        Student s1 = new Student();
        s1.DisplaySubject("TOC", "Mathematics", "English", "C# DotNet");
    }
}