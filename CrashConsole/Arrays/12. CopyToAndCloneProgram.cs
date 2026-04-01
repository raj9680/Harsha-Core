/* CopyTo and Clone: An array which stores obj of same types. 
 
    -Syntax:

    source.CopyTo(destination, 0);

    destination = source.Clone();

    Note: Difference b/w copyTo and Clone
    1. CopyTo() enquires to have an existing destination array; and the destination array
       should be large enough to hold all elements from the source array, starting from 
       the specific startIndex.
    2. CopyTo() allowsyou to specificy the start-index at destination array.
    3. The array need not to be type casted explicitly.

    4. Clone() creates a new destination array; you need not have an existing array.
    5. Clone() doesn't allow you to specify the startIndex at destination array.
    6. The result array will be returned as object so need to be type-casted.

    =======Shallow Copy And Deep Copy=======

    Shallow Copy: 
    Whatever we have copied is actually the referenceOfArray has been copied from one
    array to another not value. so if we make any changes of any of the object te actual 
    value gets updated in the actual object but not in the source array or destination 
    array. so the exact meaning of shallow copy is here whenevr the reference is getting 
    copied form one array to another array it is called shallow copy.

    Deep Copy:
    Deep copy means creating a new object and copying all values from first object to 
    another object. Both CopyTo() and Clone() dont work on DeepCopy it uses shallow copy 
    means if any change is done on source will also change to destination copied object

 */

public class Emploz
{
    public int EmpID { get; set; }
    public string? EmpName { get; set; }
}

public class ProgramC
{
    public static void MainC()
    {
        Emploz emplo = new Emploz() { EmpID = 2, EmpName = "Name One" };
        Emploz emplo1 = new Emploz() { EmpID = 3, EmpName = "Name Two" };
        Emploz emplo2 = new Emploz() { EmpID = 4, EmpName = "Name Three" };

        // Array One Prepared
        Emploz[] emploArr = new Emploz[] { emplo, emplo1, emplo2 };
        emplo.EmpName = "Updated";

        // Array Two Preparing from Copy --------------------------CopyTo
        Emploz[] emploArrCopy = new Emploz[3];
        emploArr.CopyTo(emploArrCopy, 0); // here 0 is index, ie. from start.

        Emploz[] emploArrClone = (Emploz[])emploArr.Clone();
        foreach (var item in emploArrClone)
        {
            Console.WriteLine(item.EmpName);
        }
    }
}