/* DateTime:
 */


public class NewPerson
{
    public string? PersonName { get; set; }
    public DateTime DateOfBirth { get; set; }
}

public class ProgramDT
{
    public static void MainDT()
    {
        NewPerson person = new NewPerson();
        person.PersonName = "Hellen";
        person.DateOfBirth = DateTime.Parse("1998-12-31 11:59:59.999 am");

        // OR Same
        // person.DateOfBirth = Convert.ToDateTime("1998-12-31 11:59:59.999 am");

        // Console.WriteLine(person.DateOfBirth.ToString());

        // Properties of DateTime Structure
        Console.WriteLine("Day: " + person.DateOfBirth.Day);
        Console.WriteLine("Month: " + person.DateOfBirth.Month);
        Console.WriteLine("Year: " + person.DateOfBirth.Year);
        Console.WriteLine("Hour: " + person.DateOfBirth.Hour);
        Console.WriteLine("Minute: " + person.DateOfBirth.Minute);
        Console.WriteLine("Seconds: " + person.DateOfBirth.Second);
        Console.WriteLine("Day of Week: " + person.DateOfBirth.DayOfWeek);
        Console.WriteLine("Day of Week in Num: " + (int)person.DateOfBirth.DayOfWeek); // in num
        Console.WriteLine("Days in year: " + (int)person.DateOfBirth.DayOfYear);

        //
        DateTime dt = DateTime.Now;
        Console.WriteLine(dt.ToString()); // return current date & time


    }
}