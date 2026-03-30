/* 
   Switch Expression: Switch expression is a short-form of switch case, which is used to check the value of
   source variable; assign value into result value based on the value of source variable.

   Example: Switch Expression
   
   -Syntax
   sourceVariable switch
   {
        value1 => result1;
        value2 => result2;
        ...
        _      => defaultResult;
   }

 */

public class swProgram
{
    public static void swMain()
    {
        int operation = 2;
        string result;

        result = operation switch
        {
            1 => "Customer",
            2 => "Supplier",
            3 => "Employee",
            _ => "Distributor"
        };

        Console.WriteLine(result);
    }
}