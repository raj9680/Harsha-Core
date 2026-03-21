// Explicit Interface: Creating two methodswith same signature in two different interfaces and implementing both interfaces in the same child class.

// Note: Explicit methods are bydefault private and we cannot change it.

interface IVehiclee
{
    string Move();
}

interface IFlyingMachinee
{
    string Move();
}

public class FlyingVehicle : IVehiclee, IFlyingMachinee
{
    string IVehiclee.Move() // Explicit interface
    {
        throw new NotImplementedException();
    }

    string IFlyingMachinee.Move() // Explcit interface
    {
        throw new NotImplementedException();
    }
}