// Understanding Structure vs Class (Practically)
// Also Extra: Readonly Struct - All the fields inside readonly struct can be readonly. And only assumptions is that ctors can initialise the fields values.

// Structure
public struct structureOne
{
    //fields
    public int x, y;
}

// Class
public class classOne
{
    //fields
    public int x, y;
}

// Main
public class Prowegram
{
    public static void Maicn()
    {
        structureOne structureOne; // default below values as we are assgning manually
        structureOne.x = 10;
        structureOne.y = 20;

        classOne classOne; // default null
        classOne = new classOne(); // default x = 0, y = 0;
        classOne.x = 10;
        classOne.y = 20; // now x=10, y = 20;


        // Part 2 -- Very Imp
        structureOne structure1 = new structureOne();
        structure1 = structureOne; // copied the data of structureOne instance to structure1 instance

        // Note: Data is copied (Value Type) means x=10, y=10. If we modify data it does not modify the data of structureOne as its at diffrent location.

        structure1.x = 200;
        structure1.y = 300;

        Console.WriteLine("****For Structure****");
        Console.WriteLine(structureOne.x);
        Console.WriteLine(structureOne.y);

        // Note Ref TYpe: In case of classes
        classOne classTwo;
        classTwo = classOne; // reference is same so if we change value at any ref. it will update value at all places

        classTwo.x = 30;
        classTwo.y = 40;

        // for class
        Console.WriteLine("****For Class****");
        Console.WriteLine(classOne.x);
        Console.WriteLine(classOne.y);

       
    }
}