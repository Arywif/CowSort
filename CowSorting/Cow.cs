namespace CowSorting;

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

        return Name == other.Name && Colour == other.Colour && Age == other.Age;
    }
    public override bool Equals(object c)
    {
        Cow other = c as Cow;

        return other != null && Name == other.Name && Colour == other.Colour && Age == other.Age;
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode() + Colour.GetHashCode() + Age.GetHashCode();
    }
    
    public int CompareTo(Cow other)
    {
        int x = Name.CompareTo(other.Name);

        if (x == 0)
        {
            x = Colour.CompareTo(other.Colour);

            if (x == 0)
            {
                x = other.Age.CompareTo(Age);
            }
        }

        return x;
    }
}
