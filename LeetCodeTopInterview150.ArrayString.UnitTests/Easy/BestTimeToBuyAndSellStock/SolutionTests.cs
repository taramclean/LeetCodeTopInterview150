using LeetCodeTopInterview150.ArrayString.Easy.BestTimeToBuyAndSellStock;

namespace LeetCodeTopInterview150.ArrayString.UnitTests.Easy.BestTimeToBuyAndSellStock;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var prices = new[] { 7, 1, 5, 3, 6, 4 };
        var target = new Solution();

        const int expected = 5;
        var actual = target.MaxProfit(prices);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Case2()
    {
        var prices = new[] { 7,6,4,3,1 };
        var target = new Solution();

        const int expected = 0;
        var actual = target.MaxProfit(prices);
        
        Assert.Equal(expected, actual);
    }
}