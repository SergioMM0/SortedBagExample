using System.Collections;
using SortedBagExample.Implementation;
using SortedBagExample.Interfaces;

namespace XUnitTest;

public class UnitTest1
{
    [Fact]
    public void CreateSortedBag()
    {
        //Arrange
        ISortedBag bag;
        
        //Act
        bag = new SortedBag();
        
        //Assert
        Assert.NotNull(bag);
        Assert.True(bag is SortedBag);
        
        Assert.Equal(0,bag.Count);
        
        Assert.NotNull(bag.Items);
        Assert.Empty(bag.Items);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void AddToSortedBag(int count)
    {
        //Arrange
        ISortedBag bag = new SortedBag();
        List<int> numbers = new List<int>{ 1, 1, 2 };
        List<int> expected = new List<int>{ 1, 1, 2};

        //Act
        foreach (int number in numbers.Take(count).ToList())
        {
            bag.Add(number);
        }
        //Assert
        
        Assert.Equal(count, bag.Count);
        List<int> actual = SortedBagNumbers(bag.Items);
        for (int i = 0;i < count; i++)
        {
            Assert.Equal(expected[i], actual[i]);
        }
        
        
        /*
        Assert.NotEmpty(bag.Items);
        Assert.True(bag.Items.ContainsValue(numberToAdd));
        Assert.Contains(numberToAdd, bag.Items.Values);
        Assert.Equal(1, bag.Count);
         */
    }

    private List<int> SortedBagNumbers(SortedList<int, int> items)
    {
        List<int> tmp = new();
        foreach (KeyValuePair<int,int> kvp in items)
        {
            for(int i=0; i < kvp.Value; i++)
                tmp.Add(kvp.Key);
        }

        return tmp;
    }

    [Fact]
    public void FetchFromSortedBag()
    {
        //Arrange
        ISortedBag bag;
        var expected = 1;
        
        //Act
        bag = new SortedBag();
        bag.Add(1);
        bag.Add(2);
        bag.Add(3);
        
        //Assert
        Assert.True(bag.Fetch() == expected);
        Assert.False(bag.Items.ContainsValue(expected));
        Assert.False(bag.Items.ContainsKey(expected));
    }

    [Fact]
    public void FetchFromSortedBagBiggerNumbers()
    {
        //Arrange
        ISortedBag bag;
        var expected = 20;
        
        //Act
        bag = new SortedBag();
        bag.Add(40);
        bag.Add(20);
        bag.Add(80);
        
        //Assert
        Assert.True(bag.Fetch() == expected);
        Assert.False(bag.Items.ContainsValue(expected));
        Assert.False(bag.Items.ContainsKey(expected));
    }

    [Fact]
    public void FetchFromEmptySortedBagThrowsException()
    {
        //Arrange
        ISortedBag bag;

        //Act
        bag = new SortedBag();
        Action act = () => bag.Fetch();

        //Assert
        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
        Assert.Equal("Operation not available", exception.Message);
    }
    
    
    
    
    
    
    
    
}