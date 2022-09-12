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

    [Fact]
    public void AddToSortedBag()
    {
        //Arrange
        ISortedBag bag;
        var numberToAdd = 1;
        
        //Act
        bag = new SortedBag();
        bag.Add(numberToAdd);
        
        //Assert
        Assert.NotEmpty(bag.Items);
        Assert.True(bag.Items.ContainsValue(numberToAdd));
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
        Assert.True(bag.Items.ContainsValue(expected));
        Assert.True(bag.Items.ContainsKey(expected));
    }
    
    
    
    
    
    
    
    
}