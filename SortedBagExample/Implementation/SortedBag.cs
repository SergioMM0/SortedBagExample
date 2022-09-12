using System.Collections;
using SortedBagExample.Interfaces;

namespace SortedBagExample.Implementation;

public class SortedBag : ISortedBag
{
    public int Count => Items.Count;

    public SortedList<int, int> Items { get; private set; }

    public SortedBag()
    {
        Items = new SortedList<int, int>();
    }

    public void Add(int number)
    {
        Items.Add(number,number);
    }

    public int Fetch()
    {
        var smallest = Items.Min().Value;
        Items.Remove(Items.Min().Key);
        return smallest;
    }
}