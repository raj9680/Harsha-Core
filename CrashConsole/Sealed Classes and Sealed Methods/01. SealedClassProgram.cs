// Sealed Class: Sealed class can be instantiated, but cannot be inherited. Use sealed class when you want the developers not to create child classes for the specified class. It also do not have method overriding concept applicable.
sealed class IAmSealed
{

}

//public class normal: IAmSealed // error
//{

//}