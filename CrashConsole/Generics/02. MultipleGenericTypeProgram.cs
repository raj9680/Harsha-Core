/* Multiple Generic Type:
    
*/


public class Genz<T1,T2>
{
    // generic field 1
    public T1 RegistrationStatus;

    // generic field 2
    public T2 Age;
}

public class MultipleGenericTypeProgram
{
    public static void MultipleGenericTypeMain()
    {
        Genz<int, int> user1 = new Genz<int, int>();
        Genz<bool, string> user2 = new Genz<bool, string>();

        // set value into generic field
        user1.RegistrationStatus = 1234;
        user2.RegistrationStatus = false;

        user1.Age = 10;
        user2.Age = "35 - 40";

        Console.WriteLine("Registration in Case of User 1: "+user1.RegistrationStatus);
        Console.WriteLine("Registration in Case of User 2: " + user2.RegistrationStatus);

        Console.WriteLine("Age in Case of User 1: " + user1.Age);
        Console.WriteLine("Age in Case of User 2: " + user2.Age);
    }
}