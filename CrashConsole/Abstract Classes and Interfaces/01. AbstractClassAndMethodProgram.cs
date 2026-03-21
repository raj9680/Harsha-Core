// Abstract class: An abstract class is a base class that cannot be created directly and is meant to be inherited by other classes. It can contain both complete methods and methods that must be completed (abstract method) by child classes. OR, An abstract class is a blueprint that forces child classes to follow certain rules.
// Note: We cannot create obj of abstract class

// Abstract Methods: Abstract methods are declared in parent class with abstract keyword; implemented by child classes, with override keyword.
// 
public abstract class AbsClass
{
    public string Name { get; set; }

    public string CompleteMethod() // optional to implement in child
    {
        return "I am complete method. so I am optional to re write or define again in child class";
    }

    public abstract string TempMethod(); // must for child classes to define abstract methods.
}

public class ChildClass: AbsClass
{
    public override string TempMethod() // must to implement
    {
        return "It is must for me to implement this method if I want to inherit abstract class";
    }
}

public class Progra
{
    public static void Mai()
    {
        // AbsClass aq = new AbsClass(); // not possible to instantiate abs. cls.
        AbsClass a1 = new ChildClass();
        Console.WriteLine(a1.CompleteMethod());
        Console.WriteLine(a1.TempMethod());
    }
}