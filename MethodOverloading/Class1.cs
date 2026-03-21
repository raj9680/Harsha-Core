using System.Net.Http.Headers;

namespace MethodOverloading
{
    // Multiple methods with same name with different signatures.
    public class Overloading
    {
        public string Name="Raj Kumar";
        public int Age = 27;

        public string Method()
        {
            return "My Name is: "+Name+ " and Age is: "+Age;
        }

        public string Method(string name, int age)
        {
            return "My Name is: " + name + " and Age is: " + age;
        }
    }
}
