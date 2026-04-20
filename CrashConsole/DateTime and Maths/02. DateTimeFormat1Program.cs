/* 
    DateTimeFormats 1:
 */


public class NewPersons
{
    public string? PersonName { get; set; }
    public DateTime DateOfBirth { get; set; }
}

public class ProgramSd
{
    public static void MainSd()
    {
        NewPerson person = new NewPerson();
        person.DateOfBirth = DateTime.Parse("1998-12-31 11:59:59.999");

        // To String
        string format1 = person.DateOfBirth.ToString(); // 31/12/1998 11:59:59

        // To Short Date String Format
        string format2 = person.DateOfBirth.ToShortDateString(); // 31/12/1998

        // To Long Date String Format
        string format3 = person.DateOfBirth.ToLongDateString(); // Thursday, 31 December, 1998

        // To Short Time String Format
        string format4 = person.DateOfBirth.ToShortTimeString(); // 11:59 AM

        // To Long Time String Format
        string format5 = person.DateOfBirth.ToLongTimeString(); // 11:59:59

        // Custom Format
        string format6 = person.DateOfBirth.ToString("dd-MM-yyyy HH:mm:ss"); 
        // 31-12-1998 11:59:59

        Console.WriteLine(format6); 



    }
}