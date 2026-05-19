public class Solution {
    public int[] CountBits(int n) {
        List<int> result = [];

        foreach (var number in Enumerable.Range(0, n + 1))
        {
            var sum = 0;
            var helper = number;
            while (helper != 0)
            {
                sum += helper & 1;
                helper = helper >> 1;
            }

            result.Add(sum);
        }

        return result.ToArray();
    }
}
