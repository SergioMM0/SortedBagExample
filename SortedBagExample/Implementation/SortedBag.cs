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
        throw new NotImplementedException();
    }

    public int Fetch()
    {
        throw new NotImplementedException();
    }
}