namespace CowSorting;
using System.Collections.Generic;

public class CowColourAgeComparer : IComparer<Cow>
{
    public int Compare(Cow x, Cow y)
    {
        int result = x.Colour.CompareTo(y.Colour);

        if (result == 0)
        {
            result = y.Age.CompareTo(x.Age);
        }

        return result;
    }
}