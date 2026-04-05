public class MinStack {
   private readonly Stack<(int value, int minValue)> _stack = new();

    public MinStack() {
        
    }
    
 public void Push(int val)
    {
        var minValue = _stack.Count == 0
            ? val
            : Math.Min(val, _stack.Peek().minValue);

        _stack.Push((val, minValue));
    }

    public void Pop()
    {
        _stack.Pop();
    }

    public int Top()
    {
        return _stack.Peek().value;
    }

    public int GetMin()
    {
        return _stack.Peek().minValue;
    }
}
