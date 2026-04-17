public class Solution {
    private Dictionary<int, int> memo = new Dictionary<int, int>();

    public int ClimbStairs(int n) {     
    if (n < 0)
        return 0;

    if (n == 0)
        return 1;

    if (memo.ContainsKey(n)) 
    {
        return memo[n];
    }

    return memo[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }
}