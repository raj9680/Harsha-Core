namespace Methods_And_Encapsulation
{
    public class MethodAndEncapsulation
    {
        public int productId;
        public string productName;
        public string productDescription;
        public readonly string dateOfPurchase;


        // set method for ProductID
        public void SetProductID(int value)
        {
            productId = value;
        }

        // get method for ProductID
        public int GetProductID()
        {
            return (int)productId;
        }

        // set method for ProductName
        public void SetProductName(string val)
        {
            productName = val;
        }

        // get method for ProductName
        public string GetProductName()
        {
            return (string)productName;
        }
    }
}
