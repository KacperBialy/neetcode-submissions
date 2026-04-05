public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        var result = new int[temperatures.Length];

        Stack<(int value, int index)> stack = new();
        for (var i = 0; i < temperatures.Length - 1; i++)
        {
            stack.Push((temperatures[i], i));
            if (temperatures[i + 1] <= temperatures[i])
                continue;

            while (stack.Count > 0 && stack.Peek().value < temperatures[i + 1])
            {
                var value = stack.Pop();
                result[value.index] = i + 1 - value.index;
            }
        }

        return result;
    }
}
