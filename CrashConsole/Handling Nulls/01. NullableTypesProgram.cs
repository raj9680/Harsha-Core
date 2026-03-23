/* Handling Null: Nullable Types, beofre understanding nullable types we should understand Value Types (structures, enumeration) and Reference Types (classes, interfaces)
 * ValueTypes are not nullable types (whenever data types not support null values)
 * ReferenceTypes are default nullable types (whenever data types support null values)
 * 
 * Converting Value-Types to Nullable-Types
 * Nullable<int> x= null;
 * or
 * int? x = null;
 * 
 */
// Example: How to make Value to types to be Nullable Types or to accept null values also

public class MyClass
{
    public Nullable<int> MyAge { get; set; }
    // OR
    // public int? MyAge { get; set; }
}

public class ProgramNull
{
    public static void MainNull()
    {
        MyClass c1 = new MyClass() { MyAge = 26 };
        MyClass c2 = new MyClass() { MyAge = null };
    }
}