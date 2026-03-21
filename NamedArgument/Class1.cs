namespace NamedArgument
{
    // supply value to the parameter based on parameter name.
    // calling a method
    // MethodName(ParameterName:value, ParameterName:value);
    public class NamedArg
    {
        public string Name;

        public void SetName(string namedParam)
        {
            Name = namedParam;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
