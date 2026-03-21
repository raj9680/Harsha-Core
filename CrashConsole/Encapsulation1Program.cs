using Methods_And_Encapsulation;

public class Encapsulation1Program
{
    public static void Encapsulation1()
    {
        MethodAndEncapsulation c1 = new MethodAndEncapsulation();
        c1.SetProductID(100);
        c1.SetProductName("Shoes");

        Console.WriteLine(c1.GetProductID());
        Console.WriteLine(c1.GetProductName());
    }
}