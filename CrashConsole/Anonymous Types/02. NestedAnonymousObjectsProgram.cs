/*
    Nested Anonymous Type: We can nest an anonymous object into another. Then two
    anonymous types will be created.
    
    Example: Creating Nested Anonymous Object

    var referenceVariable = new {Property1 = value, Property2 = new {Prop1 = val, Prop2 = val}, ...};
    
    // What compiler doing at backend:
    class RandomClassName
    {   
        public type Property1 {get; set;}
        public Class2 Property2 {get; set;}
    }
    
    class Class2
    {
        public type Prop1 {get; set;}
        public type Prop2 {get; set;}
    }
*/


public class ProgramNA
{
    public static void MainNA()
    {
        var refVariable = new { Property1 = "Raj Kumar", Property2 = new { Address = "This is my Address", PinCode=143001 } };
        Console.WriteLine(refVariable.Property1);
        Console.WriteLine(refVariable.Property2.Address);
        Console.WriteLine(refVariable.Property2.PinCode);
    }
}