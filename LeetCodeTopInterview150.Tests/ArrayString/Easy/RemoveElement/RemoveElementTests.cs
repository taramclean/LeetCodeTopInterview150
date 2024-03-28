using LeetCodeTopInterview150.ArrayString.Easy.RemoveElement;

namespace LeetCodeTopInterview150.Tests.ArrayString.Easy.RemoveElement;

public class RemoveElementTests
{
    [Fact]
    public void Case1()
    {
        var nums = new[] { 3, 2, 2, 3 };
        const int val = 3;
        var target = new Solution();

        const int expected = 2;
        var actual = target.RemoveElement(nums, val);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Case2()
    {
        var nums = new[] { 0,1,2,2,3,0,4,2 };
        const int val = 2;
        var target = new Solution();

        const int expected = 5;
        var actual = target.RemoveElement(nums, val);
        
        Assert.Equal(expected, actual);
    }
}