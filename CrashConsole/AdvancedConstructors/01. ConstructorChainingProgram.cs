/* Constructor Chaining: Constructor chaining is the concept which is used to called other ctor of same class from ctor itself. It is basically helpful for assigning different ctor for different operations. Ex: Lets say we have a two ctor, one is responsible for initialising name, email field and other ctor is for assigning joining date. But at last program only work when all fields are initialised. so from ctor 2 we can init ctor 1.
 * 
 * Syntax: 
    
   // Ctor One
   public Employee(string name, string email)
   {
        this.name = name;
        this.email = email;
   }
    
   // Ctor Two
   public Employee(Date joiningDate): this("Raj", "email@email.com")
   {
        this.joining = joiningDate;
   }
     
 */


public class MyClas
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateOnly Joining { get; set; }

    public MyClas(string name, string email)
    {
        this.Name = name;
        this.Email = email;
    }

    public MyClas(DateOnly date): this("Raj", "raj@email.com")
    {
        Joining = date;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Name}, {Email}, {Joining.ToString()}");
    }
}

public class ProgramCC
{
    public static void MainCC()
    {
        DateOnly date = new DateOnly();
        MyClas c1 = new MyClas(date);
        c1.DisplayInfo();
    }
}