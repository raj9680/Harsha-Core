// Partial Methods: Partial method are declared in one partial class(just like abstract method) but implemented in another partial class which has same name.

// Note: Partial methods are always have void return type.

partial class One
{
    partial void Man(); // these are private method b-default
}

partial class One
{
   /* these are private method b-default, so it can be called in public method .. see third partial class in which public method is calling it.
         */
    partial void Man() 
    {
        // method body here
    }
}

partial class One
{
    void OtherMethod()
    {
        this.Man(); // other partial class can called the partial method in normal method too. in same partial
    }
}





