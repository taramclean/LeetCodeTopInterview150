using LeetCodeTopInterview150.ArrayString.Medium.JumpGame;

namespace LeetCodeTopInterview150.ArrayString.UnitTests.Medium.JumpGame;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var nums = new[] { 2, 3, 1, 1, 4 };
        var target = new Solution();

        var actual = target.CanJump(nums);
        Assert.True(actual);
    }
    
    [Fact]
    public void Case2()
    {
        var nums = new[] { 3,2,1,0,4 };
        var target = new Solution();

        var actual = target.CanJump(nums);
        Assert.False(actual);
    }
}