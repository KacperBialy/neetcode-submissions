public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var dictionary = new Dictionary<char, int>();
        var sum = 0;
        var result = 0;

        var index = 0;
        while (index < s.Length)
        {
            if (dictionary.TryGetValue(s[index], out var value))
            {
                dictionary = [];
                index = value + 1;
                result = Math.Max(result, sum);
                sum = 0;
            }

            dictionary.Add(s[index], index);
            sum++;
            index++;
        }

        return Math.Max(result, sum);
    }
}
