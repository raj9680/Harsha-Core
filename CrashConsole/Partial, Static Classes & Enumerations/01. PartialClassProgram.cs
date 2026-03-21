/* Partial Class: Partial class is a class that splits into multiple files. Each file is treated as a "part of the class". One class can be split into multiple class but when object is created all members of its classes can be accessed.
 * 
 * At compilation time, all partial classes with same name becomes single class .
 * 
 * Note: All partial class should have same name and in the same namespace and same assembly and also have same access modifier i.e internal or public.
 * Duplicate memebrs are not allowed in PC
 * Any attributes / modifiers (such as abstract, sealed) applied on one partial class, will be applied to all partial classes that have same name.
 * partial class can also be applied on struct, interfaces ect also..
 */
partial class ClassName1
{
    public int empID { get; set; }
}

partial class ClassName1
{
    public string empName { get; set; }
}


public class Progranm
{
    public static void Maicn()
    {
        ClassName1 n1 = new ClassName1();

        Console.WriteLine(n1.empID);
        Console.WriteLine(n1.empName);
    }
}
