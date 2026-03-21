using System.Reflection.Metadata.Ecma335;

namespace RefParameterModifier
{
    /* Ref: Ref Parameter Modifier returns the updated value of parameter to the argument but the value initialization is must while calling/passing ref variable as argument during method calling from main. */

    public class RefParam
    {
        public void RefModifier(ref string name)
        {
            name = "Value should always come from caller";
        }
    }
}
