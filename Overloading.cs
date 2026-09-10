using System;

namespace OOPS_CSharp;

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