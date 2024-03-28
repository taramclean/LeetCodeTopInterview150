using LeetCodeTopInterview150.ArrayString.Easy.RemoveDuplicatesFromSortedArray;

namespace LeetCodeTopInterview150.Tests.ArrayString.Easy.RemoveDuplicatesFromSortedArray;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var nums = new[] { 1, 1, 2 };
        var target = new Solution();

        const int expected = 2;
        var actual = target.RemoveDuplicates(nums);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Case2()
    {
        var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var target = new Solution();

        const int expected = 5;
        var actual = target.RemoveDuplicates(nums);

        Assert.Equal(expected, actual);
    }
}