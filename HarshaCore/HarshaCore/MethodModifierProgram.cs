public class Main1
{
    public static void Main11()
    {
        MethodModifier m1;
        m1 = new MethodModifier();

        // Ref
        Console.WriteLine("Value of Ref. Before: "+m1.reffVariable);
        int varr = 20;
        m1.MethodModifierRef(ref varr); // value which is passed as ref variable should be pre-initialised and a variable
        Console.WriteLine("Value of Ref. After: " + m1.reffVariable);


        // Out
        Console.WriteLine("\nValue of Out Before: " + m1.outVariable);
        m1.MethodModifierOut(out m1.outVariable);
        Console.WriteLine("Value of Out After: " + m1.outVariable);

        /* Difference b/w Ref & Out
         * Ref flow goes from : function call argument -> function def. parameter -> parameter value updated inside function def. and after value modification the modified value goes back to function def. paramater -> function call argument and hence default value get updated. Note in ref. while calling method with ref variable, variable should always be pre-initialized and a variable not literal.
         * Out flow goes from: function call argument to inside the value of that variable updated inside the function definition and that updated value directly goes to the function call argument. No interefernce of function def. parameter.
         */


        // in

        string varr1 = "Cannot modify value of in Variable inside fn. definition";
        m1.MethodModifierIn(in varr1);



    }
}