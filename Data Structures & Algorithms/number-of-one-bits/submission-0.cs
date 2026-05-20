public class Solution {
    public int HammingWeight(uint n) {
        uint sum = 0;

        while (n != 0)
        {
            sum += n & 1;
            n >>= 1;
        }

        return (int)sum;
    }
}
