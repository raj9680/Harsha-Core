using System.ComponentModel.DataAnnotations.Schema;

namespace Dictionary
{
    public class Class1
    {
        public Class1()
        {
            ReturnDict();
        }

        Dictionary<int, string> emp = new Dictionary<int, string>()
        {
            { 101, "Scott" },
            { 102, "Media" },
            { 103, "Allen" }
        };

        public void ReturnDict()
        {
            foreach(var item in emp)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
