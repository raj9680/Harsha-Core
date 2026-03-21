// Enumaerations or Enum: Enumeration is a collection of constants. such as child, teenager, adult etc.
// In a variable if we want to accept some specific values only and do not want any other value to be assigned. then we use enum.
// 
// AccessingMember: 
// EnumerationName.ConstantName

public class HumanBeing
{
    public string PersonName { get; set; }
    public string Email { get; set; }
    public AgeGroupEnumeration AgeGroup { get; set; }
}

public enum AgeGroupEnumeration
{
    Child, 
    Teenager,
    Adult,
    Senior
}

public class Programee
{
    public static void Maino()
    {
        HumanBeing humanBeing = new HumanBeing();
        humanBeing.PersonName = "RAJ";
        humanBeing.Email = "email@email.com";
        humanBeing.AgeGroup = AgeGroupEnumeration.Adult;
        Console.WriteLine(humanBeing.AgeGroup);
    }
}