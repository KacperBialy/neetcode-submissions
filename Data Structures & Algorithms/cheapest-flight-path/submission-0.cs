public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        var prices = new int[n];
        Array.Fill(prices, int.MaxValue);
        prices[src] = 0;

        for (var i = 0; i <= k; i++)
        {
            var temp = (int[])prices.Clone();
            foreach (var flight in flights)
            {
                int from = flight[0], to = flight[1], cost = flight[2];

                if (prices[from] == int.MaxValue)
                    continue;

                if (prices[from] + cost < temp[to])
                    temp[to] = prices[from] + cost;
            }

            prices = temp;
        }

        return prices[dst] == int.MaxValue
            ? -1
            : prices[dst];
    }
}
