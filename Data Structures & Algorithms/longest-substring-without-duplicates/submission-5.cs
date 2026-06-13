public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var left = 0;
        var right = 0;
        var lastSeen = new Dictionary<char, int>();

        var result = 0;
        while (right < s.Length)
        {
            var value = s[right];

            if (lastSeen.TryGetValue(value, out var prev))
                left = Math.Max(left, prev + 1);

            lastSeen[value] = right;

            result = Math.Max(right - left + 1, result);

            right++;
        }

        return result;
    }
}
