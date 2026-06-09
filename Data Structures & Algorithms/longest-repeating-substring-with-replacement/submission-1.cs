public class Solution {
    public int CharacterReplacement(string s, int k) {
        var result = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var counts = new int[26];
            var maxFreq = 0;

            for (var j = i; j < s.Length; j++)
            {
                counts[s[j] - 'A']++;
                maxFreq = Math.Max(maxFreq, counts[s[j] - 'A']);

                var windowLen = j - i + 1;
                if (windowLen - maxFreq <= k)
                    result = Math.Max(result, windowLen);
            }
        }

        return result; 
    }
}