// Multiple inheritance with Interfaces: As per rule of C#, multiple places classes are not allowed. so to implement this we can use interfaces.

interface IVehicle
{
    void MoveBasedOnVehicle();
}

interface IFlyingMachine
{
    void MoveBasedOnAir();
}

public class FlyingMachine : IFlyingMachine, IVehicle
{
    public void MoveBasedOnAir()
    {
        throw new NotImplementedException();
    }

    public void MoveBasedOnVehicle()
    {
        throw new NotImplementedException();
    }
}



public class PP
{
    public static void MM()
    {

    }
}