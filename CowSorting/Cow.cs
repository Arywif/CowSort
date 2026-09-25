namespace CowSorting;

public class Cow : IEquatable<Cow>
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
    public override bool Equals(object obj)
    {
        Cow other = obj as Cow;

        return other != null && Name == other.Name && Colour == other.Colour && Age == other.Age;
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode() + Colour.GetHashCode() + Age.GetHashCode();
    }
}
