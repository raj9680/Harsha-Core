/*

    Deconstructing: Assigning the value of tuple to local variable is called deconstructing. 
    Note: Order matters

    -syntax:
    refVar = (localVar2, localVar2, ...);

*/

namespace CrashConsole.Tuples
{
    public class SimpleCT
    {
        public (int custID, string custName) GetPersonAddress()
        {
            (int custID, string custName) address = (123, "Address ABC");
            return address;
        }
    }

    public class ProgramTT
    {
        public static void MainTT()
        {
            SimpleCT s1 = new SimpleCT();
            var address = s1.GetPersonAddress();
            Console.WriteLine($"Person Address: {address.custID},{address.custName}");

            var deconstringVal1 = 0;
            var deconstringVal2 = "";

            // Assigning the value of Tuple to local variable is called deconstructing
            // Note: Order matters
            address = (deconstringVal1, deconstringVal2);
        }
    }
}
