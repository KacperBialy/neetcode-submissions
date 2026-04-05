public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();

        foreach(var word in strs)
        {
            var count = new int['z' - 'a'];

            foreach(var character in word)
                count[character - 'a']++;

            var key = string.Join(',', count);

            if(!result.ContainsKey(key))
                result.Add(key, new List<string>());
            
            result[key].Add(word);
        }

        return new List<List<string>>(result.Values);
    }
}
