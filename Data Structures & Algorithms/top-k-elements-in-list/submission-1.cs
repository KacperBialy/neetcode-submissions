public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var count = new Dictionary<int, int>();
        var freq = new List<int>[nums.Length + 1];
        for (var i = 1; i < freq.Length; i++)
            freq[i] = new List<int>();

        foreach (var n in nums)
        {
            if (!count.TryAdd(n, 1))
                count[n]++;
        }

        foreach (var keyValue in count)
            freq[keyValue.Value].Add(keyValue.Key);

        var res = new int[k];
        var index = 0;

        for(var i = freq.Length - 1; i > 0; i--)
        {
            foreach(var n in freq[i])
            {
                res[index++] = n;

                if(index == k)
                    return res;
            }
        }

        return res;
    }
}
