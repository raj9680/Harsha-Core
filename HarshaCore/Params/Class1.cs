public class Students
{
    public void DisplaySubjects(params string[] subjects)
    {
        for (int i = 0; i < subjects.Length; i++)
        {
            Console.WriteLine(subjects[i]);
        }
    }
}