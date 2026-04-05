public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        int sumOfS = 0;
        foreach(var character in s)
        {
            sumOfS += (int)character;

            if(!t.Contains(character))
                return false;
        }
        
        int sumOfT = 0;
        foreach(var character in t)
            sumOfT += (int)character;

        return sumOfS == sumOfT;
    }
}
