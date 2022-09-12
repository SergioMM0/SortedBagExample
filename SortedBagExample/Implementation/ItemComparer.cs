namespace SortedBagExample.Implementation;

public class ItemComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x.CompareTo(y);
        //No idea of what i'm actually doing xD
    }
}