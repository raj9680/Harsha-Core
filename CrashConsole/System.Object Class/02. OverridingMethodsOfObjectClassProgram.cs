// Uderstanding & Overriding Methods of Object Class
// Below are the pre-defined methods of Object class we can override
/* 
 * virtual bool Equals(object value)
 * virtual int GetHashCode();
 * virtual string ToString();
*/

public class MyPerson
{
    public int PersonID { get; set; }
    public string? PersonName { get; set; }

    public override bool Equals(object? obj)
    {
        MyPerson p = (MyPerson)obj;
        if(this.PersonID == p.PersonID && this.PersonName == p.PersonName)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return "This is custom override";
    }

}


// Main
public class Programzx
{
    public static void Mainzx()
    {
        System.Object obj = new MyPerson() { PersonID = 1, PersonName = "Raj Kumar" };

        Console.WriteLine(
            obj.Equals(new MyPerson() { PersonID = 1, PersonName = "Raj Kumar" })
        );

        // Here values are equal but it still return false, bcz of different obj.
        // so we need to override the equals method to behave as per our requirement.

        Console.WriteLine(obj.ToString()); // return current working class name but we can override to return something else

        Console.WriteLine(obj.GetType().ToString()); // return current working class name and cannot be overridden
    }
}