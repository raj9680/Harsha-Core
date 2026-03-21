// Method Overriding
// Method Hiding vs Method Overriding
// Method Hiding- Same Name, Same Parameters, Same return type not matter
// Method Overrding - Same Name, Same Parameters, Same return type & virtual keyword in parent method and override in child class. Overrding is optional.
// Overrding is run-time dynamic & hiding is compile time static.

public class parent
{
    public virtual string ParentMethod()
    {
        return "I am Parent method";
    }
}

public class child: parent
{
    public override string ParentMethod()
    {
        // return base.ParentMethod(); this will call parent method
        return "I am Child method";
    }
}

public class Programr
{
    public static void Mainr()
    {
        parent c1 = new child();
        Console.WriteLine(c1.ParentMethod());
    }
}