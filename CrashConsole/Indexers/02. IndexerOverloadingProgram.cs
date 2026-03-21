// Indexer Overloading
// Indexer - rarely used
// ref & out parameters not allowed
// it cannot be static
// can be overloaded

public class Buses
{
    // private field
    private string[] _brands = new string[] { "BMW", "Skoda", "Honda" };
    private string[] _names = new string[] { "first", "second", "third" };

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

    // overloading same like fn. overloading
    public string this[string index]
    {
        set
        {
            _brands[Array.IndexOf(_names, index)] = value;
        }
        get
        {
            return _brands[Array.IndexOf(_names, index)];
        }
    }
}


public class ProgramI
{
    public static void MainI()
    {
        Buses c = new Buses();
        Console.WriteLine(c[0]);

        Console.WriteLine(c["second"]);
    }
}