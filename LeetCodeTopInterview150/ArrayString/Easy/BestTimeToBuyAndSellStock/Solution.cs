namespace LeetCodeTopInterview150.ArrayString.Easy.BestTimeToBuyAndSellStock;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var profit = 0;
        var bestPriceToBuy = prices[0];

        for (var i = 1; i < prices.Length; i++)
        {
            profit = Math.Max(profit, prices[i] - bestPriceToBuy );
            bestPriceToBuy = Math.Min(bestPriceToBuy, prices[i]);
        }

        return profit;
    }
}