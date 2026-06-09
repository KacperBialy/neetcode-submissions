public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var lastSeen = new Dictionary<char, int>();
        var left = 0;
        var result = 0;

        for (var right = 0; right < s.Length; right++)
        {
            if (lastSeen.TryGetValue(s[right], out var prev))
                left = Math.Max(left, prev + 1);

            lastSeen[s[right]] = right;
            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}
