using System;
using System.Collections.Generic;
 
namespace CowSorting;
internal class Program
{
    static void Main(string[] args)
    {
        List<Cow> cows = new List<Cow>
        {
            new Cow("Milka", "lila", 4),
            new Cow("Paula", "weiss", 6),
            new Cow("Conny", "schwarz", 4),
            new Cow("Berta", "weiss", 7),
            new Cow("Mathias", "rosa", 4),
            new Cow("Milka", "rosa", 4),
            new Cow("Milka", "lila", 5)
        };
        cows.Sort();

        Console.WriteLine("IComparable:");
        foreach (Cow cow in cows)
        {
            Console.WriteLine(cow);
        }

        Console.WriteLine();

        cows.Sort(new CowColourAgeComparer());
        
        Console.WriteLine("Colour + Age:");
        foreach (Cow cow in cows)
        {
            Console.WriteLine(cow);
        }

        Console.WriteLine();

        cows.Sort(new CowColourNameComparer());

        Console.WriteLine("Colour + Name:");
        foreach (Cow cow in cows)
        {
            Console.WriteLine(cow);
        }
    }
}