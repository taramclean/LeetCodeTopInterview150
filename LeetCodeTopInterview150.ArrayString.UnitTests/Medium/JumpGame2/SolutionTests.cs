using LeetCodeTopInterview150.ArrayString.Medium.JumpGame2;

namespace LeetCodeTopInterview150.ArrayString.UnitTests.Medium.JumpGame2;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var nums = new[] { 2, 3, 1, 1, 4 };
        var target = new Solution();

        const int expected = 2;
        var actual = target.Jump(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Case2()
    {
        var nums = new[] { 2, 3, 0, 1, 4 };
        var target = new Solution();

        const int expected = 2;
        var actual = target.Jump(nums);
        Assert.Equal(expected, actual);
    }
}