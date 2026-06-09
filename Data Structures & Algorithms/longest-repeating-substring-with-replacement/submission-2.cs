public class Solution {
    public int CharacterReplacement(string s, int k) {
        var result = 0;
        var left = 0;

        var counts = new int[26];
        for (var right = 0; right < s.Length; right++)
        {
            counts[s[right] - 'A']++;

            var windowSize = right - left + 1;
            if (windowSize - counts.Max() > k)
            {
                counts[s[left] - 'A']--;
                left++;
                windowSize--;
            }

            result = Math.Max(result, windowSize);
        }

        return result;
    }
}