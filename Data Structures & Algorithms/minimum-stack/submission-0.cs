public class MinStack {
    private Stack<KeyValuePair<int, int>> stack;
    public MinStack() {
        stack = new Stack<KeyValuePair<int, int>>();
    }
    
    public void Push(int val) {
        int minVal = val;
        if(stack.Count() > 0)
            minVal = Math.Min(GetMin(), minVal);
        var kvp = new KeyValuePair<int, int>(val, minVal);
        stack.Push(kvp);
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().Key;
    }
    
    public int GetMin() {
        return stack.Peek().Value;
    }
}
