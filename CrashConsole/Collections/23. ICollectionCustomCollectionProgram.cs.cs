/*
    Custom Collection with ICollection: A custom collection class is a class that
    consists of collection of objects. It allows to create additional properties and
    methods useful to manipulate the collection.
    
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

namespace CrashConsole.ECollections
{
    public class CustomerCX
    {
        public int CxID { get; set; }
        public string? CxName { get; set; }
        public string? CxAddress { get; set; }
    }

    public class CxList : ICollection<CustomerCX>
    {
        private List<CustomerCX> customerList = new List<CustomerCX>();

        public int Count => customerList.Count;

        public bool IsReadOnly => false;

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(CustomerCX item)
        {
            return customerList.Contains(item);
        }

        public void CopyTo(CustomerCX[] array, int arrayIndex)
        {
            customerList.CopyTo(array, arrayIndex);
        }

        bool ICollection<CustomerCX>.Remove(CustomerCX item)
        {
            return customerList.Remove(item);
        }

        public void Add(CustomerCX customer)
        {
            customerList.Add(customer);
        }

        public void Remove(CustomerCX customer)
        {
            customerList.Remove(customer);
        }

        public CustomerCX Find(Predicate<CustomerCX> match)
        {
            return customerList.Find(match);
        }

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

    }


    public class _Program
    {
        public static void _Main()
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

            Console.WriteLine($"Total numbers of elements: {customerList.Count}");
            CustomerCX match = customerList.Find(cx => cx.CxID == 2);
            Console.WriteLine($"Element found: {match.CxID}, {match.CxName}, {match.CxAddress}");
        }
    }
}