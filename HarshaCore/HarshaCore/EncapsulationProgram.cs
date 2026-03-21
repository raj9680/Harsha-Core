public class Sample
{
    public static void Main11()
    {
        Product p1, p2;
        MethodModifier m1;



        p1 = new Product();
        p1.SetProductID(1001);
        p1.SetProductName("Product One");
        p1.cost = 2020;
        p1.quantityInStock = 3;
        Product.TotalNoProducts++;

        p2 = new Product();
        p2.SetProductID(1002);
        p2.SetProductName("Product Two");
        p2.cost = 2030;
        p2.quantityInStock = 5;
        Product.TotalNoProducts++;

        Console.WriteLine("Product ID is: " + p1.GetProductID());
        Console.WriteLine("Product ID is: " + p1.GetProductName());
        Console.WriteLine("Product ID is: " + p1.cost);
        Console.WriteLine("Product ID is: " + p1.quantityInStock);
        Console.WriteLine("Product Purchase Date is: " + p1.dateOfPurchase);


        Console.WriteLine("\nProduct ID is: " + p2.GetProductID());
        Console.WriteLine("Product ID is: " + p2.GetProductName());
        Console.WriteLine("Product ID is: " + p2.cost);
        Console.WriteLine("Product ID is: " + p2.quantityInStock);
        Console.WriteLine("Product Purchase Date is: " + p2.dateOfPurchase);

        Console.WriteLine("\nTotal number of product quantity: "+ Product.TotalNoProducts);
        // static can be common for all instances i.e see we are fetching value suing Product not p1 or p2 ref variable (value can be changed)
        Console.WriteLine("Product category: " + Product.CategoryName); // const can be common for all instances i.e see we are fetching value suing Product not p1 or p2 ref variable (value cannot be changed once init)
    }
}