// Defining multiple ctor within the same class with same name but diff. set of parameters (same like fn. overloading).
public class CtorOverloading
{
    public string Name;
    public int Age;

    public CtorOverloading()
    {
        Name = "Raj";
    }

    public CtorOverloading(int age)
    {
        Age = age;
    }
}

public class OProgram
{
    public static void OMain()
    {
        CtorOverloading c1 = new CtorOverloading();
        CtorOverloading c2 = new CtorOverloading(27);
        Console.WriteLine("Name is: "+c1.Name+"\nAge is: "+c2.Age);
    }
}