public class Solution {
    public string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();

        foreach (var str in strs)
        {
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        var decoded = new List<string>();
        var i = 0;

        while (i < s.Length)
        {
            var delimiterIndex = s.IndexOf('#', i);
            var length = int.Parse(s.AsSpan(i, delimiterIndex - i));
            decoded.Add(s.Substring(delimiterIndex + 1,  length));
            i = delimiterIndex + length + 1;
        }

        return decoded;
    }
}