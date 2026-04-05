public class Solution {
  public string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();

        foreach (var str in strs)
            sb.Append($"{str.Length}¤{str}Ω");

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        if (s == string.Empty)
            return [];

        var frames = s.Split("Ω", StringSplitOptions.RemoveEmptyEntries);

        var decoded = new List<string>();
        foreach (var frame in frames)
        {
            var length = int.Parse(frame.Split("¤")[0]);

            decoded.Add(length == 0
                ? ""
                : frame.Substring(frame.Length - length, length));
        }

        return decoded;
    }
}