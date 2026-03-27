/*
    Events: Event is a multi-cast delegate that stores one or more methods, and invoke them every time when the event is raised (called).
    
    Important pointes:
    1. It implements the architecture of publisher vs subscriber i.e events are created in the publisher class. And whenevr publisher calls the event, the corresponsing subscribe method in the subscriber class will be executed.
    2. Events can be called in the same class in which it is created.
*/

namespace Events
{
    // Step 1: create delegate
    public delegate void MyDelegateType(int a, int b);


    // publisher class
    public class Publisher
    {
        // private delegate
        private MyDelegateType myDelegate;

        // step 2: create event of created delegate type in publisher class
        public event MyDelegateType MyEvent
        {
            add
            {
                // ref of MyDelegateType is required
                myDelegate += value;
            }
            remove
            {
                myDelegate -= value;
            }
        }

        // Step 3: Defining call/raise method in same class
        public void RaiseEvent(int a, int b)
        {
            // check if the event is subscribed by any class/fn or not, if not subscribed then it will return null cauing null ref exception at runtime
            if(this.myDelegate != null)
            {
                myDelegate(a, b);
            }
        }

    }


    // Step 4: Create a target method in subscriber class
    public class Subscriber
    {
        // target method
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }


    public class Program9
    {
        public static void Main9()
        {
            // create obj of both publisher and subscriber class
            Subscriber subscriber = new Subscriber();
            Publisher publisher = new Publisher();

            // subscribing event
            publisher.MyEvent += subscriber.Add;
            // publisher.MyEvent += subscriber2.Add; - multiple subscriber can subscribe
            // publisher.MyEvent += subscriber3.Add; - multiple subscriber can subscribe

            // Raise event
            publisher.RaiseEvent(10, 20); // whever it is called or raise -- all subscriber gets triggered
        }
    }
}



/* Summary:
 * 
    Step 1: Create a Delegate
            public delegate ReturnType DelegateTypeName(param1, param2, ...);


    Step 2: Create an Event in publisher class
            
            class Publisher
            {
                private DelegateTypeName eventVariable;
                
                public event DelegateTypeName EventName
                {
                    add 
                    {
                        eventVariable += value;
                    }
                    remove
                    {
                        eventVariable -= value;
                    }
                }
            }


    Step 3: Raise Event in Publisher Class

            if(EventName != null)  
            {
                EventName(arg1, arg2, ...);
            }


    Step 4: Create Event Handler Method in Subscriber Class

            class Subscriber
            {
                public ReturnType EventHandlerMethodName(param1 , param2, ...)
                {
                    // Method body here
                }
            }


    Step 5: Subscribe to the Event [inside or outside of subscriber class]
            
            EventName += EventHandlerMethodName;

 */
