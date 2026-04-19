public class Solution {
    public int LastStoneWeight(int[] stones) {
        var list = stones.ToList();
        while (list.Count > 1)
        {
            list.Sort();
            if (list[^1] == list[^2])
            {
                list.RemoveAt(list.Count - 1);
                list.RemoveAt(list.Count - 1);
            }
            else if (list[^1] < list[^2])
            {
                list[^2] -= list[^1];
                list.RemoveAt(list.Count - 1);
            }
            else
            {
                list[^1] -= list[^2];
                list.RemoveAt(list.Count - 2);
            }
        }

        return list.Count > 0 ? list[0] : 0;
    }
}
