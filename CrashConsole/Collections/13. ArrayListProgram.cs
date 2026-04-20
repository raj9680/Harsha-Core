/* 
    
    ArrayList: It allows you to store a group of elements of any type.
    
    Syntax: 
    ArrayList refVar = new ArrayList();
    
    Example:
    ArrayList arrValueRef = new ArrayList();
    arrValueRef.Add("English");
    arrValueRef.Add(20);
    arrValueRef.Add(true);

 */

using System.Collections;

namespace Anb
{
    public class EmpClas
    {
        public string GetString()
        {
            return "String";
        }

        public int GetInt()
        {
            return 20;
        }

        public bool GetBool()
        {
            return true;
        }
    }

    public class ProgramArrL
    {
        public static void MainArrL()
        {
            ArrayList FlexibleList = new ArrayList();
            EmpClas empClass = new EmpClas();

            FlexibleList.Add(empClass.GetString());
            FlexibleList.Add(empClass.GetInt());
            FlexibleList.Add(empClass.GetBool());

            foreach (var itm in FlexibleList)
            {
                if (itm is EmpClas emp)
                {
                    string name = emp.GetString(); // this way we can get elelents of class
                }
                Console.WriteLine(itm + " - " + itm.GetType());
            }
        }
    }
}


