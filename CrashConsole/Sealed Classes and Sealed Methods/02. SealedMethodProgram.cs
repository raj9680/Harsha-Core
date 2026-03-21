// Sealed method: Sealed method must be "overidden menthod", which cannot be overidden by the other child classes.
public class class1
{
    public virtual string Method()
    {
        return "I can be overidden only once";
    }
}

public class class2: class1
{
    public sealed override string Method()
    {
        return "I am overidden in Child already";
    }
}

public class class3 : class2
{
    //public override string Method()
    //{
    //    return "I am trying to update again";
    //}

    // uncomment above
}