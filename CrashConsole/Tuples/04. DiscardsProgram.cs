/*

    Discard: Discards used to skip a value which we dont need using underscore(_)

    -syntax: after creating value tuple
    (type variableName, _) = refVariable;

*/

namespace CrashConsole.Tuples
{
    public class SimpleCC
    {
        public (int custID, string custName) GetPersonAddress()
        {
            (int custID, string custName) address = (123, "Address ABC");
            return address;
        }
    }

    public class ProgramD
    {
        public static void MainD()
        {
            SimpleCC s1 = new SimpleCC();
            (_, string custName) = s1.GetPersonAddress();
            Console.WriteLine("ID is Discarded");
            Console.WriteLine(custName);
        }
    }
}
