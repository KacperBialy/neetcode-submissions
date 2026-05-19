public class Solution {
    public int[] CountBits(int n) {
        var result = new int[n + 1];

        foreach (var number in Enumerable.Range(0, n + 1))
        {
            result[number] = result[number >> 1] + (number & 1);
        }

        return result;
    }
}
