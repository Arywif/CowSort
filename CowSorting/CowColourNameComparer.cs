namespace CowSorting;
using System.Collections.Generic;

public class CowColourNameComparer : IComparer<Cow>
{
    public int Compare(Cow x, Cow y)
    {
        int result = x.Colour.CompareTo(y.Colour);

        if (result == 0)
        {
            result = x.Name.CompareTo(y.Name);
        }

        return result;
    }
}