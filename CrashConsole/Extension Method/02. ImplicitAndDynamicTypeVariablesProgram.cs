/* Implicitly Types Variables: The variables which are declared with 'var' keyword are called as 'implicitly-typed' variables (type-inference). Data type of implicitly typed cariable is fixed at initials i.e cannot be changed later override.

 * example: var VariableName = value; 
 * 
 * compiler automatically checks
 *  
 *  Dynamically Typed Variable: Dynamically typed variable are the variables that are declared with 'dynamic' keyword.Data type of dynamic variable is never fixed it can be changed any time. Use dynamic type variable when we are unsure about the values we use or store.
 *  
 *  Note: C# compiler skips type-checking of dynamic type variables, instead it resolves at runtime.
 *  
 *  example: dynamic variableName = value;
*/

public class Progr_am
{
    public static void Mai_n()
    {
        var varName = "Test";
        // varName = 21; // cause error as initially it stores string value so now cannot store int type value.

        dynamic x;
        x = "Hello";  
        x = 23; // but in case of dynamic we can overwrite data type

        // dynamic type variables are more error prone & no intellisense
    }
}