/* Generics: Generics in C# is dynamic dataTypes which is decided at the tym of object creation. It allows us the flexibility to use same class or fields used for multiple data types.
 
    SYNTAX:

    class className<T> 
    {
        public T fieldName;
    }

    className<int> referenceVariable = new className<int>();        // for int as data type
    className<string> referenceVariable = new className<string>(); // for string as data type

 */


public class Gen<T>
{
    public T personName;
}

public class Prograzm
{
    public static void Maizn()
    {
        Gen<int> genInt = new Gen<int>();
        Gen<string> genStr = new Gen<string>();

        genInt.personName = 20;
        Console.WriteLine(genInt.personName);

        genStr.personName = "RAJ";
        Console.WriteLine(genStr.personName);
    }
}