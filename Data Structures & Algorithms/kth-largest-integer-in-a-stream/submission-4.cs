public class KthLargest
{
    private List<int> _topValues;
    private int kth;

    public KthLargest(int k, int[] nums)
    {
        _topValues = new List<int>(nums.OrderByDescending(num => num).Take(k));
        kth = k;
    }

    public int Add(int val)
    {
        _topValues.Add(val);
        _topValues = _topValues.OrderBy(topValue => topValue)
            .ToList();

        if (_topValues.Count > kth)
            _topValues.RemoveAt(0);

        return _topValues[0];
    }
}
