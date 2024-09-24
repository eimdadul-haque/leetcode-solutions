var prices = new int[] { 7, 1, 5, 3, 6, 4 };
var solution = new Solution();
var result = solution.MaxProfit(prices);
Console.WriteLine(result);

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0)
        {
            return 0;
        }

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices) {
            if (price < minPrice) { 
                minPrice = price;
            }
            else if (price - minPrice > maxProfit)
            {
                maxProfit = price - minPrice;
            }
        }

        return maxProfit;
    }
}