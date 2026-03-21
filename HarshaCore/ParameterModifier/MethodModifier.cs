public class MethodModifier
{
    /* Types of Method Modifiers: default, ref, out, in
     * 
     */

    public int reffVariable;
    public int MethodModifierRef(ref int reff)
    {
        reffVariable = reff * 10;
        return 0;
    }

    public int outVariable;
    public int MethodModifierOut(out int outt)
    {
        outt = 10;
        return 0;
    }

    public string MethodModifierIn(in string inn)
    {
        //inn = "Cannot modify parameter variable i.e. inn value it is only readonly";
        return inn;
    }
}