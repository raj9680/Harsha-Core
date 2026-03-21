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

    // Set method for ProductID
    public void SetProductID(int value)
    {
        productID = value;
    }

    // Get method for ProductID
    public int GetProductID()
    {
        return productID;
    }

    // Set method for ProductName
    public void SetProductName(string value)
    {
        productName = value;
    }

    // Get method for ProductName
    public string GetProductName()
    {
        return productName;
    }
}

