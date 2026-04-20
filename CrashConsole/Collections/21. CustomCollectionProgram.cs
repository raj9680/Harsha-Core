/*
    Custom Collection: A custom collection class is a class that consists of collection 
    of objects. It allows to create additional properties and methods useful to manipulate 
    the collection.
    
    Syntax:

    public class ClassName: IEnumerable
    {
        private List<yourClassName> list = new List<yourClassName>();
        
        public IEnumerator GetEnumerator()
        {
            for(int index=0; index<list.Count; indx++)
            {
                yield return list[index];
            }
        }
        ....
        // can add additional methods
    }

*/

using System.Collections;

namespace CrashConsole.Collections
{
    public class CustomerCX
    {
        public int CxID { get; set; }
        public string? CxName { get; set; }
        public string? CxAddress { get; set; }
    }

    public class CxList : IEnumerable
    {
        private List<CustomerCX> customerList = new List<CustomerCX>();

        public IEnumerator GetEnumerator()
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


    public class Programnb
    {
        public static void Mainnm()
        {
            /*

            CxList customerList = new CxList();
            IEnumerator customerList1 = customerList.GetEnumerator();

            customerList1.MoveNext();
            Console.WriteLine(customerList1.Current);

            customerList1.MoveNext();
            Console.WriteLine(customerList1.Current);

            */

            // Real World Way
            CxList customerList = new CxList();
            //IEnumerator customerList1 = customerList.GetEnumerator(); it is happenning internally

            // For Adding Cx
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


            // For Removing
            // customerList.Remove(cx[1]);


            // For Reading
            foreach (CustomerCX customer in customerList)
            {
                Console.WriteLine($"CxID: {customer.CxID}, CxName: {customer.CxName}, CxAddress: {customer.CxAddress}");
            }
        }
    }
}