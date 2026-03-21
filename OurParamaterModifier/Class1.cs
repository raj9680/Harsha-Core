namespace OurParameterModifier
{
    /* Out: Out Parameter Modifier returns the updated value of parameter to the argument directly but the value initialization is optional while calling/passing out variable as argument during method calling from main. 
     
    Note: using out, we can also return two or more values i.e one from return and others from out.
     */
    public class Class1
    {
        public string paramValue;
        public string OutParamModifier(out string name)
        {
            name = "No Need to pass value from caller";
            return "I am Second Value";
        }
    }
}
