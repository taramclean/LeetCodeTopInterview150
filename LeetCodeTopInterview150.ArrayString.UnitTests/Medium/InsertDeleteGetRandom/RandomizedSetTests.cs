using LeetCodeTopInterview150.ArrayString.Medium.InsertDeleteGetRandom;

namespace LeetCodeTopInterview150.ArrayString.UnitTests.Medium.InsertDeleteGetRandom;

public class RandomizedSetTests
{
    [Fact]
    public void Insert_Value_Already_Present_Returns_False()
    {
        var target = new RandomizedSet();
        target.Insert(1);
        
        var actual = target.Insert(1);
        
        Assert.False(actual);
    }
    
    [Fact]
    public void Insert_Value_Not_Present_Returns_True()
    {
        var target = new RandomizedSet();
        
        var actual = target.Insert(1);
        Assert.True(actual);
    }

    [Fact]
    public void Remove_Value_Not_Present_Returns_False()
    {
        var target = new RandomizedSet();

        var actual = target.Remove(1);
        Assert.False(actual);
    }

    [Fact]
    public void Remove_Value_Present_Returns_True()
    {
        var target = new RandomizedSet();
        target.Insert(2);
        target.Insert(1);

        var remove2 = target.Remove(2);
        var insert = target.Insert(2);
        var remove1 = target.Remove(1);
        
        Assert.True(remove2);
        Assert.True(insert);
        Assert.True(remove1);
    }

    [Fact]
    public void GetRandom()
    {
        var target = new RandomizedSet();
        target.Insert(1);

        const int expected = 1;
        var actual = target.GetRandom();
        Assert.Equal(expected, actual);

    }
}