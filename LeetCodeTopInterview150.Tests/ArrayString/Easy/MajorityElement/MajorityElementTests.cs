using LeetCodeTopInterview150.ArrayString.Easy.MajorityElement;

namespace LeetCodeTopInterview150.Tests.ArrayString.Easy.MajorityElement;

public class MajorityElementTests
{
    [Fact]
    public void Case1()
    {
        var nums = new[] { 3, 2, 3 };
        var target = new Solution();

        const int expected = 3;
        var actual = target.MajorityElement(nums);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Case2()
    {
        var nums = new[] { 2, 2, 1, 1, 1, 2, 2 };
        var target = new Solution();

        const int expected = 2;
        var actual = target.MajorityElement(nums);

        Assert.Equal(expected, actual);
    }
}