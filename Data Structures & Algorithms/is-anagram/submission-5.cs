public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> dictionary = new();

        foreach (var character in s)
        {
            if (!dictionary.TryAdd(character, 1))
                dictionary[character]++;
        }

        foreach (var character in t)
        {
            if (!dictionary.ContainsKey(character))
                return false;

            dictionary[character]--;
        }

        return dictionary.All(keyValue => keyValue.Value == 0);
    }
}
