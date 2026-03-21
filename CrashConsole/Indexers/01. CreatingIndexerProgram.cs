// Indexer - rarely used
// ref & out parameters not allowed
// it cannot be static
// can be overloaded

public class Bus
{
    // private field
    private string[] _brands = new string[] { "BMW", "Skoda", "Honda" };

    // public indexer
    public string this[int index]
    {
        set
        {
            _brands[index] = value;
        }
        get
        {
            return _brands[index];
        }
    }
}


public class Prog
{
    public static void Mai()
    {
        Bus c = new Bus();
        Console.WriteLine(c[0]);

        c[0] = "Jaguar";
        Console.WriteLine(c[0]);
    }
}