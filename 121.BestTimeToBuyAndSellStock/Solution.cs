namespace LeetCode.Problem121;

/// <summary>
/// 121. Best Time to Buy and Sell Stock
/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/.
/// </summary>
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var min = int.MaxValue;
        var maxProfit = 0;

        foreach (var price in prices)
        {
            if (price < min)
            {
                min = price;
                continue;
            }

            if (price - min > maxProfit)
            {
                maxProfit = price - min;
            }
        }

        return maxProfit;
    }
}