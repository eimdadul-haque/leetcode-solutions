public class Program
{
    public static void Main(string[] args)
    {
        int res = MaxProfit(new int[] {1,2,4,2,5,7,2,4,9,0,9});
    }
    public static int MaxProfit(int[] prices)
    {
        int maxProfit = 0, 
        left = 0;
        
        for (int right = 1; right < prices.Length; right++)
        {
            if(prices[left] < prices[right])
            {
                int profit = prices[right] - prices[left];
                if(profit > maxProfit)
                   maxProfit = profit;
            }
            else
                left = right;
        }

        return maxProfit;
    }
}