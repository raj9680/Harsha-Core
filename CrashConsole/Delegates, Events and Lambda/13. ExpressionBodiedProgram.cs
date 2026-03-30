/* 
   Expression Bodied Methods: Expression bodied members allows the developers to use "Inline Lambda 
   Expressions" to create methods, property accessors, constructors, destructiors, indexers in class.

   Examples:

   - Syntax
   public ReturnType MethodName() => statement;   

   - Method using Expression Bodies Methods - with return value
   public ReturnType MethodName() => AnyValue;

 */

public class _Student
{
    public int StudentAge { get; set; }
    public string? StudentName { get; set; }

    // Expression bodies method
    public int StudentNameLength() => StudentName.Length;

    // Expression bodied for ctor, but can init only one field.
    public _Student() => StudentName = "Raj";

    // in case of prop
    public string studentName
    {
        set => StudentName = value;
        get => StudentName;
    }
}

public class expProgram
{
    public static void expMain()
    {
        _Student _student = new _Student() { StudentAge = 22, StudentName="Raj Kumar"};
        int result = _student.StudentNameLength();

        Console.WriteLine(_student.StudentName);
        Console.WriteLine(result);
    }
}