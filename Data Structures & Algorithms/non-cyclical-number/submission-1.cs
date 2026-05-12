public class Solution {
    public bool IsHappy(int n) {
           var visited = new HashSet<int>();

            while (true)
            {
                if (!visited.Add(n))
                    return false;

                var sum = n.ToString()
                    .Select(character => int.Parse(character.ToString()))
                    .Sum(digit => digit * digit);

                if (sum == 1)
                    return true;

                n = sum;
        }
    }
}
