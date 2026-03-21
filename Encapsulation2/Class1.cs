namespace Encapsulation2
{
    public class Encapsulation2i
    {
        private int productID;
        private string productName;
        public string productDescription;

        public void setProductID(int value)
        {
            productID = value;
        }

        public int getProductID()
        {
            return productID;
        }
    }


    public class Encapsulation3i
    {
        public Encapsulation3i()
        {
            Encapsulation2i obj = new Encapsulation2i();

            // here we are using the public method for updating the private field as we cannot directly access private field.
            obj.setProductID(100);
        }
    }
}
