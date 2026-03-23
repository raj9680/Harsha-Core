/* Null Coalescing Operator: i.r ?? (it check whether the variable value is null, if variable is null it return value at right hand side & if variable value is not null then same variable value is returned ) i.e shortcut of if 
 * 
 * variablename ?? valueIfNull
 * 
 * Block One
 * if(A.HasValue)
   {
       Console.WriteLine(2);
   }
 * 
 * Block Two
   Console.WriteLine((HasValue) ? 2 : 0);
   if  HasValue(not null) then it print 2 else 0

   Block one & Block Two do same thing
 */


public class Programnull
{
    public static void Mainnull()
    {
        int? x = 21;
        // int? x = null;

        Console.WriteLine(x.HasValue ? x : 0);
        // OR shorter
        // Console.WriteLine(x ?? 0);
        // Console.WriteLine(x ?? "Hello");   -- X
        // if x has value then it will be return its value else 0 if null
        // Note:: In this case the value should always be of same data type ie. if variable x is of int type then it will retun only int not string
    }
}