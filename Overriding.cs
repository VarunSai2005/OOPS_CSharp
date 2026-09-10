using System;

namespace OOPS_CSharp;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal cries"); 
    }
}
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
} 
class Overriding
{
    static void Main(string [] args)
    {
        Dog a = new Dog();
        a.Sound(); 
    }
}
