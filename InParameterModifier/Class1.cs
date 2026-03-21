namespace InParameterModifier
{
    public class InParam
    {
        public void InParamModifier(in string name)
        {
            // name = "RAJ"; 
            // in case of 'in' PM, cannot modify value of parameter. value can only be passed from caller
        }
    }
}
