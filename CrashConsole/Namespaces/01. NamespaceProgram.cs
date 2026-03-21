// namespace: namespaces are used to group set of classes, interfaces as any namespace name i.e HR in namespace HR block .. see below example. i.e interface & class HumanResource are under HR namespace block .

namespace HR
{
    interface Person
    {
        string Salary();
    }

    public class HumanResource : Person
    {
        public string Salary()
        {
            throw new NotImplementedException();
        }
    }
}


public class Program0
{
    public static void Main0()
    {
        HR.Person p1 = new HR.HumanResource(); //accessing class/interface in nmsp.
    }
}