using System;

namespace OOPS_CSharp;

class Abstraction
{
    static void Main ( string [] args)
    {
       Tiger tiger = new Tiger();
       tiger.Cry1();
       tiger.Cry2();
    }
}

// Using abstract class
public abstract class Animal
{
    public abstract void Cry1();
}

// Using interface
interface IAnimal
{
    void Cry2();
}

// Tiger inherits from Animal
// AND implements IAnimal
public class Tiger : Animal, IAnimal
{
    public override void Cry1()
    {
        Console.WriteLine("A tiger roars.");
    }

    public void Cry2()
    {
        Console.WriteLine("It is heard up to 3 kms.");
    }
}