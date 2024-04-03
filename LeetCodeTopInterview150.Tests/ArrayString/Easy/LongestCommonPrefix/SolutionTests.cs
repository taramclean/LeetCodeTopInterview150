using LeetCodeTopInterview150.ArrayString.Easy.LongestCommonPrefix;

namespace LeetCodeTopInterview150.Tests.ArrayString.Easy.LongestCommonPrefix;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var strs = new[] { "flower", "flow", "flight" };
        var target = new Solution();

        const string expected = "fl";
        var actual = target.LongestCommonPrefix(strs);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Case2()
    {
        var strs = new[] { "dog","racecar","car" };
        var target = new Solution();

        const string expected = "";
        var actual = target.LongestCommonPrefix(strs);
        
        Assert.Equal(expected, actual);
    }
}