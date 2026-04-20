/*
    Anonymous Arrays: You can create 'array of anonymous objects' or  
    'implicitly typed array' with group of anonymous objects.
    
    Note: All objects must contain same set of property with same data type.
    
    Example: Creating Anonymous Array Object / Implicitly Typed Array

    var referenceVariable = new []
    {
        new { Property1 = value, Property2 = value, ... },
        new { Property1 = value, Property2 = value, ... }
    }
    
    // What compiler doing at backend:

    class RandomClassName
    {   
        public type Property1 {get; set;}
        public type Property2 {get; set;}
    }
*/


public class ProgramAA
{
    public static void MainAA()
    {
        var refVariable = new[]
        {
            new { Property1 = "Name", Property2 = "Email" },
            new { Property1 = "Age",  Property2 = "Gender" }
        };

        foreach (var item in refVariable)
        {
            Console.WriteLine(item.Property1+" "+item.Property2);
        }
    }
}