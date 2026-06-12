public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var dict = Enumerable.Range('a', 26)
            .ToDictionary(value => (char)value, _ => 0);

        if (s1.Length > s2.Length)
            return false;

        foreach (var character in s1)
            dict[character]++;

        for (var stop = 0; stop < s2.Length; stop++)
        {
            dict[s2[stop]]--;

            if (stop >= s1.Length)
                dict[s2[stop - s1.Length]]++;

            if (stop >= s1.Length - 1 && dict.Values.All(d => d == 0))
                return true;
        }

        return false;
    }
}
