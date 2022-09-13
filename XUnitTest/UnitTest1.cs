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