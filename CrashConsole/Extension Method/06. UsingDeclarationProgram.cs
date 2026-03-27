/* Using Declaration: you can prefix 'using' keyword before the local variable declaration, in order to call 'Dispose' method when that variable goes out of scope.

    Example 1: This is using declaration
    public void Method() 
    {
        using ClassName referenceVariable = new ClassName();
        // to do work here

    } dispose will be called here automatically & destroy ClassName variable;

    
    Example 2: This is using structure
    public void Method()
    {
        using (MyDisposable a1 = new MyDisposable())
        {
            a1.DisplayDataFromDB();
        }
    }

 * 
 *
 */

