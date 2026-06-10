public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var start = 0;
        var windowSize = s1.Length;

        while (windowSize <= s2.Length)
        {
            var substring = s2[start..windowSize];
            if (Valid(substring, s1))
                return true;
            else
            {
                start++;
                windowSize++;
            }
        }

        return false;

        bool Valid(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            return a.GroupBy(c => c)
                .All(g => b.Count(c => c == g.Key) == g.Count());
        }
    }
}
