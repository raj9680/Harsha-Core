// Static Class: Static class is a class that only contain "static members". It cannot contain even single instance member.
// We can prevent accidental creation of obj. by making any class static.

public static class Country
{
    public static string CountryName = "India";

    public static int MethodOne()
    {
        return 0;
    }
}

public class Programq
{
    public static void Mainq()
    {
        //Country c1 = new class1(); // error
        Country.MethodOne(); // correct
    }
}