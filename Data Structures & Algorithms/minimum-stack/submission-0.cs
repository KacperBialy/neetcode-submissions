public class MinStack {
    private readonly List<(int value, int minValue)> _values = new();

    public MinStack() {
        
    }
    
 public void Push(int val)
    {
        var minValue = _values.Count == 0
            ? val
            : Math.Min(val, _values[^1].minValue);

        _values.Add((val, minValue));
    }
    
    public void Pop()
    {
        _values.RemoveAt(_values.Count - 1);
    }
    
    public int Top()
    {
        return _values[^1].value;
    }
    
    public int GetMin()
    {
        return _values[^1].minValue;
    }
}
