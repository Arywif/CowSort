namespace CowSorting;
using System;
using System.Collections.Generic;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        List<Cow> cows = new List<Cow>();

        Console.WriteLine(File.Exists("inputFile.txt"));

        foreach (string line in File.ReadAllLines("inputFile.txt"))
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            if (line.StartsWith("#"))
            {
                continue;
            }

            string[] parts = line.Split(';', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 3)
            {
                Console.WriteLine($"Ungültige Zeile: {line}");
                continue;
            }

            if (!int.TryParse(parts[2], out int age))
            {
                Console.WriteLine($"Ungültiges Alter: {line}");
                continue;
            }

            cows.Add(new Cow(parts[0], parts[1], age));
        }

        Console.WriteLine($"\nAnzahl Kühe: {cows.Count}\n");

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