/*
    Generic Custom Collection (IEnumerable): A custom collection class is a class that
    consists of collection of objects. It allows to create additional properties and methods 
    Flexible

*/

using System.Collections;

namespace CrashConsole.CollectionsGeneric
{
    public class CustomerCX
    {
        public int CxID { get; set; }
        public string? CxName { get; set; }
        public string? CxAddress { get; set; }
    }

    public class CxList : IEnumerable<CustomerCX>
    {
        private List<CustomerCX> customerList = new List<CustomerCX>();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        // interface method
        public IEnumerator<CustomerCX> GetEnumerator()
        {
            for (int i = 0; i < customerList.Count; i++)
            {
                yield return customerList[i];
            }
        }

        public void Add(CustomerCX customer)
        {
            customerList.Add(customer);
        }

        public void Remove(CustomerCX customer)
        {
            customerList.Remove(customer);
        }

    }


    public class Program_
    {
        public static void Main_()
        {
            CxList customerList = new CxList();

            List<CustomerCX> cx = new List<CustomerCX>()
            {
                new CustomerCX { CxID= 1, CxName="ABC", CxAddress="ABC Address"},
                new CustomerCX { CxID= 2, CxName="DEF", CxAddress="DEF Address"},
                new CustomerCX { CxID= 3, CxName="GHI", CxAddress="GHI Address"}
            };

            foreach (CustomerCX customer in cx)
            {
                customerList.Add(customer);
            }

            foreach (CustomerCX customer in customerList)
            {
                Console.WriteLine($"CxID: {customer.CxID}, CxName: {customer.CxName}, CxAddress: {customer.CxAddress}");
            }
        }
    }
}