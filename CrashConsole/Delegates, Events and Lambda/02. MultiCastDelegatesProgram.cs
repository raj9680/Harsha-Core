/*
    Single-cast Delegate: Contains reference of only one method. When called, it directly invoke singel method.
    
    Multi-cast Delegate: Contains reference of two or more methods. When called, it directly invoke all the reference methods one by one in a sequence. All method's parametrs and return type should be same. Only last executed method's return type will be returned (updated most recent). It will not return all methods return type.


*/


public class MySam
{
    // Step 1 - target method
    public int Add(int a, int b)
    {
        return a + b;
    }

    // target method
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

// Step 2 - creating delegate
public delegate int MyDelegateOne(int a, int b);

public class Programooo
{
    public static void Mainooo()
    {
        // invoking delegate
        MySam s1 = new MySam();

        MyDelegateOne oneDelegate;
        oneDelegate  = new MyDelegateOne(s1.Add);
        oneDelegate += s1.Multiply;

        Console.WriteLine(oneDelegate.Invoke(4, 4));



        // if different values to pass to both fn then //

        // MyDelegateOne oneDelegate = new MyDelegateOne(s1.Add);
        // MyDelegateOne TwoDelegate = new MyDelegateOne(s1.Multiply);

        // oneDelegate.Invoke(4, 4);
        // twoDelegate.Invoke(6, 4);
    }
}