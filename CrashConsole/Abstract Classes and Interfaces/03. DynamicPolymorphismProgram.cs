/* Dynamic Polymorphism
// What is Polymorphism and Types: Calling different method at different situation. 
// There are two types of polymorphism: Compile-time(Method Overloading) Also known as early binding. and run-time (Method Overriding) also known as late-binding or dynamic binding
*/

/* Achieving Dynamic Polymorphism using interfaces:
 * just replace the abstract class with interface class in below example
 */


/*Compile-Time PolymorphismExample- Method Overloading:
 
 public void Add(int a, int b);
 public void Add(int a, int b, int c);
  
*/

/* Run-Time PolymorphismExample using abstract class- Method Overriding: 

abstract class ParentClass
{
    public abstract void Add(int a, int b);
}

class ChildClass_1 : ParentClass
{
    public override void Add(int a, int b)
    {
        Console.WriteLine("Must to implement this method");
    }
}

class ChildClass_2 : ParentClass
{
    public override void Add(int a, int b)
    {
        Console.WriteLine("Must to implement this method");
    }
}

public class Program
{
    public static void Main()
    {
        ParentClass p1;
        p1 = new ChildClass_1();
        p1.Add(1,2);
        
        p1 = new ChildClass_2();
        p1.Add(2,3);
 
        // overwrite the obj. so that at runtime prev. obj get deleted. this is called runtime polymorphism.
    }
}
*/