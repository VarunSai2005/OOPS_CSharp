using System;

namespace OOPS_CSharp;

class Encapsulation
{
    static void Main ( string [] args)
    {
        Animal animal = new Animal("Snake");
        Console.WriteLine(animal.Species);
    }
}

public class Animal
{
    private string species;
    public Animal( string species)
    {
        Species = species;
    }
    public string Species
    {
        get { return species; }
        set { 
            if( value == "Snake" ) species = "Dragon";
            else species = value;
            }
    }
}
