namespace RefReturns
{
    // ref return: The return type 'ref' returns the reference of returned variable of a method.
    // var retref = Method();
    public class Class1
    {
        public int grade = 2;

        public ref int DoWork()
        {
            return ref grade;
        }
    }
}
