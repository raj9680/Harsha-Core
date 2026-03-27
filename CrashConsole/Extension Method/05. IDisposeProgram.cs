/* IDisposable: Is a pre-defined interface of 'System' namespace, has a method called 'dispose', which is used to close un-managed resources that are creating during the life-time of the object.
* 
* example:

    class ClassName: System.IDisposable
    {
        public void Dispose()
        {
            // close un-managed resources here
        }
    }

    OR

    using(ClassName c1 = new ClassName()) 
    {
        // your code here
    }

* 
*/

using System.Runtime.InteropServices;

public class MyDisposable: IDisposable
{
    //constructor
    public MyDisposable()
    {
        Console.WriteLine("Database connected");
    }

    //method
    public void DisplayDataFromDB()
    {
        Console.WriteLine("Data displayed");
    }

    //dispose
    public void Dispose()
    {
        Console.WriteLine("Database closed");
    }
}

public class ProgramID
{
    public static void MainID()
    {
        //create obj using 'usng structure',benefits of this is this at the end of using structure dispose method from ref var a1 is automaticaly gets called
        using (MyDisposable a1 = new MyDisposable())
        {
            a1.DisplayDataFromDB();
        }
    }
}