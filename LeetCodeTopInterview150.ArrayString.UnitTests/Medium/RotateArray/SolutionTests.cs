using LeetCodeTopInterview150.ArrayString.Medium.RotateArray;

namespace LeetCodeTopInterview150.ArrayString.UnitTests.Medium.RotateArray;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var nums = new[] { 1, 2, 3, 4, 5, 6, 7 };
        const int k = 3;
        var target = new Solution();

        var expected = new int[] { 5, 6, 7, 1, 2, 3, 4 };
        target.Rotate(nums, k);
        
        Assert.Equal(expected, nums);
    }
    
    [Fact]
    public void Case2()
    {
        var nums = new[] { -1,-100,3,99 };
        const int k = 2;
        var target = new Solution();

        var expected = new int[] { 3,99,-1,-100 };
        target.Rotate(nums, k);
        
        Assert.Equal(expected, nums);
    }
}