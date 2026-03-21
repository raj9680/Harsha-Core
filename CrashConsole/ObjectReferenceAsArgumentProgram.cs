using ObjectReferenceAsArgument;

public class ObjectReferenceAsArgumentProgram
{
    public static void ObjectReferenceAsArgumentMain()
    {
        Product p1 = new Product();
        Product p2 = new Product();
        Product p3 = new Product();
        p1.SetProductQuantity(10);
        p2.SetProductQuantity(20);
        p3.SetProductQuantity(30);

        // passing ref. variable as arg. to static method.
        Console.WriteLine("Total Quantity: "+Product.GetTotalQuantity(p1, p2, p3 ));
    }
}