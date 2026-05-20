public class Solution {
    public int HammingWeight(uint n) {
        var sum = 0;

        while (n != 0)
        {
            if ((n & 1) == 1)
                sum++;

            n >>= 1;
        }

        return sum;
    }
}
