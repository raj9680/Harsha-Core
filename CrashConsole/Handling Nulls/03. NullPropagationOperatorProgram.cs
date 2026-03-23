/* Null Propagation Operator:
 * 
 *
 * referenceVariable?.fieldName
 * --is same as--
 * (referencevariable == null)? null: referenceVariable.fieldName;
 * 
 * 
 * it means "first it will check the value of referenceVariable whether is it null or not, if it is not null then only it will access the further value of fieldName & if referenceVariable is null then it will return overall null & not access the further value of fieldName.
 * 
 * 
 * OVERALL ADVANTAGE IF NULL REFERENCE VARIABLE IS AVOIDING THE NULL REFERENCE EXCEPTION
 * 
 */

public class IAmClass
{
    public IAmClass()
    {
        this.Age = 27;
        this.Name = "RAJ";
    }
    public int Age { get; set; }
    public string Name { get; set; }
}

public class PrograNm
{
    public static void MaiNn()
    {
        IAmClass c1 = null;
        // c1 = new IAmClass();
        Console.WriteLine(c1?.Age); // with Null Propagation Operator - Work but return null value dont cause error
        Console.WriteLine(c1.Name); // without Null Propagation Operator -- not work code break and retun Null Ref Exception

        // OR
        // Console.WriteLine((c1 == null) ? null : c1.Age);
    }
}