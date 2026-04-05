public class Solution {
    public bool IsPalindrome(string s)
    {
        var leftIndex = 0;
        var rightIndex = s.Length - 1;

        while (leftIndex <= rightIndex)
        {
            while (!char.IsAsciiLetterOrDigit(s[leftIndex]) && s.Length - 1 > leftIndex)
            {
                leftIndex++;
            }

            while (!char.IsAsciiLetterOrDigit(s[rightIndex]) && rightIndex > 0)
            {
                rightIndex--;
            }

            if (leftIndex > rightIndex)
                return true;

            if (char.ToLower(s[leftIndex]) != char.ToLower(s[rightIndex]))
                return false;

            leftIndex++;
            rightIndex--;
        }

        return true;
    }
}