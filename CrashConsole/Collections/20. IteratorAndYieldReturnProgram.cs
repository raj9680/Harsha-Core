/*
    Iterator and Yield: 

 */

using System.Linq;

public class Ssample
{
    public List<double> Myprice = new List<double>() { 90, 34, 12, 80 };

    public IEnumerable<int> Method()
    {
        Console.WriteLine("Iterator method executes");
        yield return 10;
        Console.WriteLine("Iterator method executes continued");
        yield return 20;
    }

    
    // real-world example
    public IEnumerable<double> GetMyPrice()
    {
        double sum = 0;
        foreach(double price in Myprice)
        {
            sum += price;
            yield return sum;
        }
    }
}

public class ProgramIT
{
    public static void MainIT()
    {
        /*
        
        Ssample sample = new Ssample();
        var enumerable = sample.Method();
        var enumerator1 = enumerable.GetEnumerator();

        enumerator1.MoveNext();
        Console.WriteLine(enumerator1.Current);

        // Can have other methods of processes to run

        enumerator1.MoveNext();
        Console.WriteLine(enumerator1.Current); // can use for loop also

        */


        // real-world example

        Ssample s = new Ssample();
        var prices_enumerable = s.GetMyPrice();
        var prices_enmerator = prices_enumerable.GetEnumerator();

        int z = 1;
        foreach(var item in prices_enumerable)
        {
            prices_enmerator.MoveNext(); // 90
            Console.WriteLine($"Total price upto {z} product:" + prices_enmerator.Current);
            z++;
        }
    }
}