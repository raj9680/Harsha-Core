namespace NewPractice
{
    public delegate void DelegateName(string message);

    public class Publisher
    {
        public void Add(string a)
        {
            Console.WriteLine(a);
        }

        public void Sub(string a)
        {
            Console.WriteLine(a);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Publisher publicher = new Publisher();

            DelegateName delegateAdd = publicher.Add;
            delegateAdd += publicher.Sub;

            delegateAdd.Invoke("Method Invoked");
        }
    }
}