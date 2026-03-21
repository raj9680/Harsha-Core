namespace GoToStatement
{
    public class GoToStatement1
    {
        public void GoTo()
        {
            Console.WriteLine("USA");
            Console.WriteLine("Japan");
            Console.WriteLine("Germany");
            Console.WriteLine("India");
            goto mylabel;

            Console.WriteLine("South Africa");

            mylabel:
            Console.WriteLine("Nepal");
        }
    }
}
