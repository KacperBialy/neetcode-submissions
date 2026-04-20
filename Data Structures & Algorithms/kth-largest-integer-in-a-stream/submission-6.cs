public class KthLargest
{
    private PriorityQueue<int, int> _topValues;
    private int _kth;

    public KthLargest(int k, int[] nums)
    {
        _kth = k;
        _topValues = new PriorityQueue<int, int>();
        foreach (var num in nums)
        {
            _topValues.Enqueue(num, num);
            if (_topValues.Count > k)
                _topValues.Dequeue();
        }
    }

    public int Add(int val)
    {
        _topValues.Enqueue(val, val);

        if (_topValues.Count > _kth)
            _topValues.Dequeue();

        return _topValues.Peek();
    }
}
