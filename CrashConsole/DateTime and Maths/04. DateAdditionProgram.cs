/* 
    Date Addition:
    
    DateTime AddDays(double value)
    DateTime AddMonths(double value)
    DateTime AddYears(double value)
    DateTime AddHours(double value)
    DateTime AddMinutes(double value)
    DateTime AddSeconds(double value)
    DateTime AddMilliSeconds(double value)

 */

public class ProgramDA
{
    public static void MainDA()
    {
        DateTime dateOfJoining = DateTime.Parse("2022-01-01 12:00 am");
        DateTime afterTenDays = dateOfJoining.AddDays(10); // To Add
        DateTime deductTenDays = dateOfJoining.AddDays(-10); // To Deduct

        DateTime AddTenMonths = dateOfJoining.AddMonths(10); // To Add Months

        Console.WriteLine(AddTenMonths);


    }
}