using System.Collections;
using SortedBagExample.Interfaces;

namespace SortedBagExample.Implementation;

public class SortedBag : ISortedBag
{
    public int Count
    {
        get;
        private set;
    }

    public SortedList<int, int> Items { get; private set; }

    public SortedBag()
    {
        Items = new SortedList<int, int>();
    }

    public void Add(int number)
    {
        if (!Items.ContainsKey(number))
        {
            Items.Add(number,1);
        }
        else
        {
            Items[number]++;
        }

        Count++;
    }

    public int Fetch()
    {
        if (Items.Any())
        {
            var smallest = Items.First().Value;
            foreach (KeyValuePair<int,int> kvp in Items)
            {
                if (kvp.Value < smallest)
                {
                    smallest = kvp.Value;
                }
            }

            Items.Remove(smallest);
            return smallest;
        }
        throw new InvalidOperationException("Operation not available");
    }
}