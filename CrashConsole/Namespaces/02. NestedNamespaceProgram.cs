// nested namespaces: the namespace which is declared inside another namespace is called nested namespace.

namespace OuterNamespace
{
    interface Test1
    {
        void Foo();
    }

    class test1 : Test1
    {
        public void Foo()
        {
            throw new NotImplementedException();
        }
    }

    // another namespace
    namespace InnerNamespace
    {
        class testClass
        {
            // nothing
        }
    }
}