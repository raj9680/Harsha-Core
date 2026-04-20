/* 
    Date Subtraction:
    
    Return type of : int CompareTo(DateTime value)
    -1: This instance value is earlier than value.
     0: This instance value is equal to value.
     1: This instance value is later than value.
    
    TimeSpan Subtract(DateTime value)
    It returns an instance of TimeSpan structure, that represents date difference between 
    the current instance and given date value.
 */


public class ProgramDS
{
    public static void MainDS()
    {
        DateTime dateOfJoining = DateTime.Parse("2025-01-01");
        DateTime today = DateTime.Now;

        if(today.CompareTo(dateOfJoining) == 1) // 1, 0, -1
        {
            TimeSpan ts = today.Subtract(dateOfJoining);
            Console.WriteLine($"In Days: {ts.TotalDays}");
            Console.WriteLine($"In Years: {Math.Floor(ts.TotalDays / 365)}");

            Console.WriteLine($"In Months: {(ts.TotalDays / 365) * 12}");
        }
        else
        {
            Console.WriteLine("Date of Joining is greater than today's date. Subtraction is not allowed.");
        }
    }
}