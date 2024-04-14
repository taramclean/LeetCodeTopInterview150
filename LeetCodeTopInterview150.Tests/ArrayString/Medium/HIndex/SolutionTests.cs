using LeetCodeTopInterview150.ArrayString.Medium.HIndex;

namespace LeetCodeTopInterview150.Tests.ArrayString.Medium.HIndex;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var citations = new[] { 3, 0, 6, 1, 5 };
        var target = new Solution();

        const int expected = 3;
        var actual = target.HIndex(citations);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Case2()
    {
        var citations = new[] { 1, 3, 1 };
        var target = new Solution();

        const int expected = 1;
        var actual = target.HIndex(citations);

        Assert.Equal(expected, actual);
    }
}