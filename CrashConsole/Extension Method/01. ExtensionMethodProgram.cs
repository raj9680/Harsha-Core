/* 
 * Extension Method: Extension method is a method injected into an existing class (), without modifying the source code of that class (or struct or interface).
 * 
 * Syntax Example:

   // Existing Class
   class ClassName
   {
        
   }

   static class ClassName
   {
       public static ReturnType MethodName(this ClassName ParameterName)
       {
            // here 'this ClassName' is the class or m
            // method body here
       }
   }

 * 
*/

using System.Diagnostics;

public class ProductClass
{
    public double ProductPrice { get; set; }
    public double ProductDiscount { get; set; }
}


public static class ProductExtensions
{
    public static double GetDiscount(this ProductClass productClass)
    {
        productClass.ProductPrice = productClass.ProductPrice - (productClass.ProductPrice * productClass.ProductDiscount/100);

        return productClass.ProductPrice;
    }
}


public class Programz
{
    public static void Mainz()
    {
        ProductClass productClass = new ProductClass();
        productClass.ProductPrice = 1000;
        productClass.ProductDiscount = 30;

        Console.WriteLine(productClass.GetDiscount());
    }
}