/* 
    Event Handler: It is a pre-defined delegate type, which has two parameters called 'object sender'
    and 'EventArgs e'; and no return.

    Note: Return type of event handler is always void.

    1. Object sender: Is of object type which represents the current object of subscriber class. That
       means in which class you are subscribing the same current object is represented as sender
       parameter. The subscriber class can be of any class that is why the data type of sender is 
       object. In this case object is representing System.object class which is the parent class of
       all all the classes, structures and all other types.

    2. EventArgs e: It represents paramters i.e. additional values that you want to supply to the 
       subscription method. Bydefault it contains no properties. It is recommended to create child 
       class for 'EventArgs' class.

    Example: Creating events based on event handler
    
             public event EventHandler eventName;

 */

namespace EventHandler
{
    public class CustomEventArgs : EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    public class Publishher
    {
        public event EventHandler<CustomEventArgs>? myEvent;

        public void RaiseEvent(object sender, int aa, int bb)
        {
            CustomEventArgs customEventArgs = new CustomEventArgs() { a = aa, b = bb };

            Console.WriteLine("Event Handler does not return any value");
            Console.WriteLine($"Value of a: {customEventArgs.a}, and value of b: {customEventArgs.b}");
            
            if (myEvent != null)
            myEvent(sender, customEventArgs);

            //OR
            // myEvent(this, customEventArgs); // 'this' is to know the data-type of subscriber class
        }
    }

    public class EHProgram
    {
        public static void EHMain()
        {
            EventHandler.EHProgram program = new EventHandler.EHProgram();
            program.DoWork();
        }


        // main method does not return object of current wrking class so, we should create diff method
        public void DoWork()
        {
            Publishher publisher = new Publishher();

            publisher.myEvent += (sender, e) => // only two parameters
            {
                int summ = e.a + e.b;
                Console.WriteLine("Sum is: "+summ+"\n");
            };

            publisher.RaiseEvent(this, 1, 2);
            publisher.RaiseEvent(this, 2, 3);
        }
    }
}