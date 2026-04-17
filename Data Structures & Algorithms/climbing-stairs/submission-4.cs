public class Solution {
    public int ClimbStairs(int n) {     
        return Enumerable.Range(0, n - 1)
            .Aggregate((One: 1, Two: 1), (acc, _) => (acc.One + acc.Two, acc.One))
            .One;
    }
}