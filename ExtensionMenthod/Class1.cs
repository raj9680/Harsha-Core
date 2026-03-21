using System.Runtime.CompilerServices;

namespace ExtensionMenthod
{
    public class Product
    {
        public double ProductPrice;
        public double ProductDiscount;
    }


    // Separate Class
    public static class ProductExtension
    {
        public static double GetDiscount(this Product product)
        {
            return product.ProductPrice * product.ProductDiscount / 100;
        }
    }
}
