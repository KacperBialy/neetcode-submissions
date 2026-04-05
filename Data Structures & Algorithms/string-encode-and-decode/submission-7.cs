public class Solution {
    public string Encode(IList<string> strs)
    {
    return strs.Count == 0
        ? ""
        : string.Join("Ω", strs) + "Ω";
    }

    public List<string> Decode(string s)
    {
        if (s == "")
            return []
                ;
        if (s == "Ω") return [""];

        return s[..^1].Split('Ω').ToList();
    }
}
