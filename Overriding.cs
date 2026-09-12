using System;

namespace OOPS_CSharp;

/*
Method Overriding
1. Multiple methods of same name in different class.
2. Inheritance is used, as it is in different class.
3. All methods have same signature.
4. It’s a run time polymorphism. 
5. Virtual & override keywords.
*/

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
