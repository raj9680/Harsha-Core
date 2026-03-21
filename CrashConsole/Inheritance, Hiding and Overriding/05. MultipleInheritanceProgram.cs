// Multiple Inheritance: When one child inheriting multiple parent classes.
// Note: Multiple inheritance can only be implemented using interfaces.

public interface Animal
{
    // Parent class 1
}

public interface Mammal
{
    // Parent class 2
}

public class Human: Animal, Mammal
{
    // Child clas implementing two parent class
}