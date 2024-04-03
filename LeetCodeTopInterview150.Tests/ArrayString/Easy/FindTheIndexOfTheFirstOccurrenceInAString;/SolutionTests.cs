using LeetCodeTopInterview150.ArrayString.Easy.FindTheIndexOfTheFirstOccurrenceInAString;

namespace LeetCodeTopInterview150.Tests.ArrayString.Easy.FindTheIndexOfTheFirstOccurrenceInAString_;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        const string haystack = "sadbutsad"; 
        const string needle = "sad";

        var target = new Solution();
        const int expected = 0;
        var actual = target.StrStr(haystack, needle);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Case2()
    {
        const string haystack = "leetcode"; 
        const string needle = "leeto";

        var target = new Solution();
        const int expected = -1;
        var actual = target.StrStr(haystack, needle);
        
        Assert.Equal(expected, actual);
    }
}