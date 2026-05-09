public class Solution {
    public int[] PlusOne(int[] digits) {
        var add = 1;
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            add += digits[i];
            if (add == 10)
            {
                digits[i] = add % 10;
                add = 1;
            }
            else
            {
                digits[i] = add;
                return digits;
            }
        }

        return [1, ..digits];
    }
}
