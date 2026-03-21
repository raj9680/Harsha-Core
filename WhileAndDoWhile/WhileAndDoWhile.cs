namespace WhileAndDoWhile
{
    public class While
    {
        public void MethodWhile()
        {
            int x = 10;
            while (x > 5)
            {
                Console.WriteLine(x);
                x--;
            }
        }
        
    }



    public class DoWhile
    {
        int s = 10;

        public void DoWhileMethod()
        {
            do
            {
                Console.WriteLine(s);
                s--;
            }
            while (s > 5);
        }
    }
}
