namespace SortedBagExample.Interfaces;

public interface ISortedBag
{
    public int Count { get;}
    public SortedList<int, int> Items { get; }

    /// <summary>
    /// Adds the given number into the SortedBag.
    /// </summary>
    /// <param name="number">
    /// The number to add to the SortedBag
    /// </param>

    void Add(int number);
    /// <summary>
    /// Returns and removes the smallest value from the SortedBag
    /// If the SortedBag is empty, an InvalidOperationException is thrown.
    /// </summary>
    /// <returns>
    ///Returns the smallest value in the SortedBag
    /// </returns>
    int Fetch();
}