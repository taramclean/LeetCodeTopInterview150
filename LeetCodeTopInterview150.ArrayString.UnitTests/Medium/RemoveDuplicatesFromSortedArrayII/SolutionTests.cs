using LeetCodeTopInterview150.ArrayString.Medium.RemoveDuplicatesFromSortedArrayII;

namespace LeetCodeTopInterview150.ArrayString.UnitTests.Medium.RemoveDuplicatesFromSortedArrayII;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var nums = new[] { 1, 1, 1, 2, 2, 3 };
        var target = new Solution();

        const int expected = 5;
        var actual = target.RemoveDuplicates(nums);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Case2()
    {
        var nums = new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
        var target = new Solution();

        const int expected = 7;
        var actual = target.RemoveDuplicates(nums);

        Assert.Equal(expected, actual);
    }
}