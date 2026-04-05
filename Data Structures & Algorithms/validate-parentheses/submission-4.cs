public class Solution {
    public bool IsValid(string s) {
            var stack = new Stack<char>();
            var closeToOpen = new Dictionary<char, char>
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };

            foreach (var c in s)
            {
                if (closeToOpen.TryGetValue(c, out var value))
                {
                    if (stack.Count == 0)
                        return false;

                    if (stack.Pop() != value)
                        return false;
                }
                else
                    stack.Push(c);
            }

            return stack.Count == 0;
    }
}
