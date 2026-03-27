/* 
    1. Delegates: Delegate type is a type that represents methods that have specific parameters and return type. We can call one or more methods indirectly using delegates. It can store ref of one or more methds.
    Example:
    a). Creating Delegate: public delegate ReturnType DelegateTypeName(param1, param2, ...);

    b). Creating Delegate Object: DelegateTypeName ReferenceVariable = MethodName;

    c). Invoke method using Delegate: ReferenceVariableName.Invoke(arg1, arg2, ...);


    2. Events:

    Auto Implemented Events:

    Anonymous Method:

    Lambda Expression:
    






*/


// Step 1
public class MySample
{
    //target method
    public int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }
}

// Step 2: Create delegate type
public delegate int MyDelegateType(int a, int b); 
// delegate return type and method should always match the target method


public class Programdd
{
    public static void Maindd()
    {
        MySample s1 = new MySample();

        //step 3: create delegate object or delegate
        MyDelegateType myDelegate;

        //add method reference to delegate
        myDelegate = new MyDelegateType(s1.Add);

        //invoke method using myDelegate
        Console.WriteLine(myDelegate.Invoke(2, 3));
    }
}