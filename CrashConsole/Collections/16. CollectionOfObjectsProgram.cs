/* 
    Collection of Objects: 'Collection of object' is an collection object, where each element 
    stores reference to some other object. Used store group of people or things.
    
    Syntax: 
    List<ClassName> refVar = new List<ClassName>();
    refVar.Add(object1);
    refVar.Add(object2);
    refVar.Add(object3);

 */

public class ObjProducts
{
    public int ProductID { get; set; }
    public string? ProductName { get; set; }
}

public class ProgramOb
{
    public static void MainOb()
    {
        List<ObjProducts> products = new List<ObjProducts>();

        string choice;
        do
        {
            int pid = new Random().Next(1, 101);

            Console.WriteLine("Enter Name: ");
            string? pName = Console.ReadLine();

            products.Add(new ObjProducts { ProductID = pid, ProductName = pName });

            Console.WriteLine("Would you like to Continue? Yes/No: ");
            choice = Console.ReadLine();

        } while (choice != "No" && choice != "no" && choice != "N" && choice != "n");

        products.Sort((x, y) => x.ProductID.CompareTo(y.ProductID)); // IMP

        foreach (var item in products)
        {
            Console.WriteLine($"Result is : Product ID: {item.ProductID} and Product Name: {item.ProductName}");
        }
    }
}