namespace ObjectReferenceAsArgument
{
    // Passing ref. variable as arguments to methods & receiving them.
    public class Product
    {
        public int productQuantity;
        public void SetProductQuantity(int val)
        {
            productQuantity = val;
        }

        public int GetProductQuantity()
        {
            return productQuantity;
        }


        // getting ref. variable as arg. from main method
        public static int GetTotalQuantity(Product val1, Product val2, Product val3)
        {
            return val1.productQuantity + val2.productQuantity + val3.productQuantity;
        }
    }
}
