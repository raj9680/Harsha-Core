public class Mainn
{
    public static void Main_()
    {
        Student s1;
        s1 = new Student();
        s1.PrintGrade();

        // call DoWork
        ref int g = ref s1.DoWork();
        g = 5;
        // update the valueof 'ref return'
        s1.PrintGrade();
    }
}