using LeetCodeTopInterview150.ArrayString.Easy.LengthOfLastWord;

namespace LeetCodeTopInterview150.ArrayString.UnitTests.Easy.LengthOfLastWord;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        const string s = "Hello World";
        var target = new Solution();

        const int expected = 5;
        var actual = target.LengthOfLastWord(s);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Case2()
    {
        const string s = "   fly me   to   the moon  ";
        var target = new Solution();

        const int expected = 4;
        var actual = target.LengthOfLastWord(s);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Case3()
    {
        const string s = "luffy is still joyboy";
        var target = new Solution();

        const int expected = 6;
        var actual = target.LengthOfLastWord(s);
        
        Assert.Equal(expected, actual);
    }
    
}