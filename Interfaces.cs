using System;

namespace OOPS_CSharp;

interface ICry
{
    void Cry();
}
interface IType
{
    void Type();
}
public class Animal : ICry, IType
{
    public void Cry()
    {
        Console.Write("Sound of an animal.");
    } 
    public void Type()
    {
        Console.Write("Herbivorous / Omnivorous / Carnivorous");
    } 
}

public class Interfaces
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Cry();
        animal.Type();
    }
}