// Interface Inheritance: When one interface inheriting other interface, then it is called Interface Inheritance.

interface Iclass11
{
    string Tst1();
}

interface Iclass12: Iclass11
{
    string Tst2();
}

class ChildClass11 : Iclass12
{
    public string Tst1()
    {
        throw new NotImplementedException();
    }

    public string Tst2()
    {
        throw new NotImplementedException();
    }
}


public class Programo
{
    public static void Maino()
    {
        Iclass11 i = new ChildClass11();
        i.Tst1(); // calls ChildClass11 method only but below

        //

        Iclass12 ii = new ChildClass11();
        ii.Tst1();
        ii.Tst2();  // can call both methods. 

    }
}