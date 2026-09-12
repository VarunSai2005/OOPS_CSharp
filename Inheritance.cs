using System;

namespace OOPS_CSharp;

// Classes & Interfaces
public class Minato
{
    public void MinatoHas()
    {
        Console.WriteLine("Flying Raijin and Rasengan.");
    }
}

public class Kushina
{
    public void KushinaHas()
    {
        Console.WriteLine("Adamantine Sealing Chains.");
    }
}

// Single Inheritance
public class Naruto : Minato
{
    public void NarutoHas()
    {
        Console.WriteLine("Kurama, Rasengan and Rasenshuriken.");
    }
}

public class Hinata
{
    public void HinataHas()
    {
        Console.WriteLine("Byakugan and Gentle Fist.");
    }
}

// Multilevel Inheritance
public class Boruto : Naruto
{
    public void BorutoHas()
    {
        Console.WriteLine("Rasengan, Vanishing Rasengan and Flying Raijin.");
    }
}

// Hierarchical Inheritance
public class Himawari : Naruto
{
    public void HimawariHas()
    {
        Console.WriteLine("Kurama and Byakugan potential.");
    }
}

// Multiple Inheritance Using Interfaces
public interface UzumakiAbilities
{
    void UseChakra();
}

public interface HyugaAbilities
{
    void UseByakugan();
}

public class Kawaki : Naruto, UzumakiAbilities, HyugaAbilities
{
    public void UseChakra()
    {
        Console.WriteLine("Uses chakra-based abilities.");
    }

    public void UseByakugan()
    {
        Console.WriteLine("Byakugan ability through interface.");
    }

    public void KawakiHas()
    {
        Console.WriteLine("Karma and scientific ninja tools.");
    }
}

// Main Class
class Inheritance
{
    static void Main(string[] args)
    {
        // Single Inheritance
        Naruto naruto = new Naruto();
        Console.WriteLine("Methods available with Naruto");
        naruto.MinatoHas();
        naruto.NarutoHas();

        // Multilevel Inheritance
        Boruto boruto = new Boruto();
        Console.WriteLine("\nMethods available with Boruto");
        boruto.MinatoHas();
        boruto.NarutoHas();
        boruto.BorutoHas();

        // Hierarchical Inheritance
        Himawari himawari = new Himawari();
        Console.WriteLine("\nMethods available with Himawari");
        himawari.MinatoHas();
        himawari.NarutoHas();
        himawari.HimawariHas();

        // Multiple Inheritance Using Interfaces
        /*Because, C# traditionally doesn't support multiple inheritance
        it must be implemented using interfaces*/
        Kawaki kawaki = new Kawaki();
        Console.WriteLine("\nMethods available with Kawaki");
        kawaki.NarutoHas();
        kawaki.UseChakra();
        kawaki.UseByakugan();
        kawaki.KawakiHas();
    }
}