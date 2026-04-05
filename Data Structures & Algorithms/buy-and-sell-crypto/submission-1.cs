public class Solution {
    public int MaxProfit(int[] prices)
    {
        if (prices.Length < 2)
            return 0;

        var currentPriceIndex = 0;
        var nextPriceIndex = 1;

        var maxProfit = 0;
        while (nextPriceIndex < prices.Length)
        {
            var price = prices[currentPriceIndex];
            var nextPrice = prices[nextPriceIndex];

            if (nextPrice > price)
                maxProfit = Math.Max(maxProfit, nextPrice - price);
            else
                currentPriceIndex = nextPriceIndex;

            nextPriceIndex++;
        }

        return maxProfit;
    }
}
