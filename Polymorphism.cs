using System;

namespace OOPS_CSharp;

class Polymorphism
{
    static void Main ( string [] args)
    {
        Tiger tiger = new Tiger();
        Wolf wolf = new Wolf();
        Elephant elephant = new Elephant();

        Animal [] animals = {tiger, wolf, elephant};

        foreach( var obj in animals)
        {
            obj.Instinct();
        }
    }
}

public class Animal
{
   public virtual void Instinct()
    {
        
    }
}
public class Tiger : Animal
{
    public override void Instinct()
    {
        Console.WriteLine("Tiger is a solitary animal.");
    }
}
public class Wolf : Animal
{
    public override void Instinct()
    {
        Console.WriteLine("Wolves hunt in packs.");
    }
}
public class Elephant : Animal
{
    public override void Instinct()
    {
        Console.WriteLine("Elephants are highly intellectual.");
    }
}