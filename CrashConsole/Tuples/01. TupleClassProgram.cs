/*

    Tuple: The system.tuple class represents a set of values of any data type.
    > Useful to return multiple values from a method (or) to pass multiple values
    to a method.
    > Represents a set of values quickly without creating a separate class.
    
    var refVariable = new Tuple<type1, type2, ...>(value1, value2, ...);

*/

namespace SampleCLass
{
    public class Simple
    {
        public Tuple<string, int> GetPersonAddress()
        {
            Tuple<string, int> address = new Tuple<string, int>("Address ABC", 123);
            return address;
        }
    }

    public class ProgramTC
    {
        public static void MainTC()
        {
            Simple s1 = new Simple();
            var address = s1.GetPersonAddress();
            Tuple<string, int> person = new Tuple<string, int>("Drew", 24);
            Console.WriteLine($"Person Details: {person.Item1}, {person.Item2}");
            Console.WriteLine($"Person Address: {address.Item1}, {address.Item2}");
        }
    }
}
