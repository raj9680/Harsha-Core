/*

    Auto Implemented Events: "Auto implemented Events" provide a shortcut syntax to create events with less code. In this case you need to not to create "add" or "remove" accessors, compiler handler it on their own.

    Example:
        
    class Publisher
    {
        public event DelegateType MyEvent;
    }
 
 * 
 */

namespace AutoImplemented
{
    // Delegate for Events
    public delegate void MyDelegateTyp(string a, int b);


    // Publisher Class
    public class Publisher
    {
        // Step 1: Create Event
        public event MyDelegateTyp myEvent; // Add or Remove accessor is happening internally

        // private MyDelegateTyp myDelegateTyp; -- handled auto
  
        // Step 2: Raise Event
        public void RaiseEvent(string a, int b)
        {
            // instead of accessing the private delegate we can use myEvent
            if(this.myEvent != null)
            {
                this.myEvent(a, b);
            }
        }
    }


    // Subscriber Class
    public class Subscriber
    {
        // target method
        public void Add(string a, int b)
        {
            Console.WriteLine(a+" "+b);
        }
    }


    public class ProgramAuto
    {
        public static void MainAuto()
        {
            Publisher P1 = new Publisher();
            Subscriber S1 = new Subscriber();

            // Subscription
            P1.myEvent += S1.Add;

            // Whener raised -- All subscribers triggers
            P1.RaiseEvent("Raj", 20);
        }
    }

}