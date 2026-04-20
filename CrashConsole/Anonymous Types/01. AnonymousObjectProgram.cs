/*
    When you create an object with a set of properties along with values, 
    automatically c# compiler creates a class (with a random name) with specified 
    properties. It is called as 'anonymous type' or 'anonymous classes'
    
    Example: Creating Anonymous Object

    var referenceVariable = new {Property1 = value, Property2 = value, ...};
    
    // What compiler doing at backend:
    class RandomClassName
    {   
        public type Property1 {get; set;}
        public type Property2 {get; set;}
    }
*/



public class ProgramAO
{
    public static void MainAO()
    {
        var refVariable = new { Property1 = "Hello", Property2 = 2001 };
        Console.WriteLine(refVariable.Property1);
        Console.WriteLine(refVariable.Property2);
    }
}