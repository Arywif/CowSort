namespace CowSorting;
using System;

public class Cow : IEquatable<Cow>, IComparable<Cow>
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    public Cow(string name, string colour, int age)
    {
        Name = name;
        Colour = colour;
        Age = age;
    }

    public bool Equals(Cow other)
    {
        if (other == null)
            return false;

        return Name == other.Name &&
               Colour == other.Colour &&
               Age == other.Age;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Cow);
    }

    public override int GetHashCode()
    {
        return (Name + Colour + Age).GetHashCode();
    }

    public int CompareTo(Cow other)
    {
        int result = Name.CompareTo(other.Name);

        if (result == 0)
        {
            result = Colour.CompareTo(other.Colour);

            if (result == 0)
            {
                result = other.Age.CompareTo(Age);
            }
        }

        return result;
    }

    public override string ToString()
    {
        return $"{Name}, {Colour}, {Age}";
    }
}