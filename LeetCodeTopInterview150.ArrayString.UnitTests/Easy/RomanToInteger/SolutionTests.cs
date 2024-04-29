using LeetCodeTopInterview150.ArrayString.Easy.RomanToInteger;

namespace LeetCodeTopInterview150.ArrayString.UnitTests.Easy.RomanToInteger;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        const string s = "III";
        var target = new Solution();

        const int expected = 3;
        var actual = target.RomanToInt(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Case2()
    {
        const string s = "LVIII";
        var target = new Solution();

        const int expected = 58;
        var actual = target.RomanToInt(s);

        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Case3()
    {
        const string s = "MCMXCIV";
        var target = new Solution();

        const int expected = 1994;
        var actual = target.RomanToInt(s);

        Assert.Equal(expected, actual);
    }
}