public class Product
{
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    // initialising value of readonly inside ctor // cannot be modified later
    public Product()
    {
        dateOfPurchase = DateTime.Now.ToShortDateString();
    }
}

