using System;

namespace OOPS_CSharp;

/*
Method Overloading
1. Multiple methods of same name in single class.
2. No need of inheritance, as it is in single class.
3. All methods have different signature.
4. It’s a compile time polymorphism. 
5. No special keyword used.
*/
public class Adding
{
    public int Add(int a, int b)
    {
        return a+b;
    }
    public string Add(string a, string b)
    {
        return a+b;
    }
    public double Add(double a, double b)
    {
        return a+b;
    }
}
class Overloading : Adding
{
    static void Main(string [] args)
    {
        Adding a = new Adding();
        Console.WriteLine(a.Add(1, 2));
        Console.WriteLine(a.Add("Hello ", "World"));
        Console.WriteLine(a.Add((double)1.2, (double)3.4));
    }
}