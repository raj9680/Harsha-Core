/*

    Value Tuples: Value Tuples are advancement to 'Tuple' class with simplified 
    syntax. 
    > Supports unlimted values.
    > We can access elements with real field name unlike item1, item2.
    > Can be used a method parameters / return value; much like tuple class.
    
    -syntax:
    (type fieldName1, type fieldName2, ...) refVar = (value1, value2, ...);

*/

namespace CrashConsole.Tuples
{
    public class SimpleTC
    {
        public (int custID, string custName) GetPersonAddress()
        {
            (int custID, string custName) address = (123, "Address ABC");
            return address;
        }
    }

    public class ProgramVT
    {
        public static void MainVT()
        {
            SimpleTC s1 = new SimpleTC();
            var address = s1.GetPersonAddress();
            Console.WriteLine($"Person Address: {address.custID},{address.custName}");
        }
    }
}
