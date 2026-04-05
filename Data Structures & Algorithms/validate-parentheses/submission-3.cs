public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
                const string openBrackets = "({[";

                foreach (var bracket in s)
                {
                    if (openBrackets.Contains(bracket))
                        stack.Push(bracket);
                    else
                    {
                        if (stack.Count == 0)
                            return false;

                        var lastOpenBracket = stack.Pop();
                        switch (lastOpenBracket)
                        {
                            case '(' when bracket != ')':
                            case '[' when bracket != ']':
                            case '{' when bracket != '}':
                                return false;
                        }
                    }
                }

                return stack.Count == 0;
    }
}
