namespace ParameterModifiers
{
    // Types:
    // 1. Default [no keyword] - Default parameter is like normal passing value in argument like other functions calling but the value of parameter of calling method should not affect the argument during calling method.

    // 2. ref -
    // 3. out -
    // 4. in  -
    // 5. params -
    public class ParaModifiers
    {
        public string Name; 

        public string Default(string val)
        {
            Name = val;
            Name = Name+" "+Name;
            return Name;
        }
    }
}
