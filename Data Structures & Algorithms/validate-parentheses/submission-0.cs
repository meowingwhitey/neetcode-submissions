public class Solution 
{
    public bool IsValid(string s) 
    {
        var stack = new Stack<char>();

        foreach(char c in s)
        {
            if(stack.Count == 0)
            {
                stack.Push(c);
                continue;
            }
            char p = stack.Peek();
            if(
                (p == '{' && c == '}') ||
                (p == '[' && c == ']') ||
                (p == '(' && c == ')') 
            )
            {
                stack.Pop();
                continue;
            }
               
            if(
                (p == '{' && (c == ']' || c == ')')) || 
                (p == '[' && (c == '}' || c == ')')) ||
                (p == '(' && (c == '}' || c == ']'))
            )
            {
                return false;
            }
            stack.Push(c);
        }

        if(stack.Count % 2 == 1)
            return false;
        
        while(stack.Count > 0)
        {
            char c1 = stack.Pop();
            char c2 = stack.Pop();
            if(
                (c2 == '{' && c1 == '}') ||
                (c2 == '[' && c1 == ']') ||
                (c2 == '(' && c1 == ')') 
            )
            {
                Console.WriteLine($"c1: {c1}, c2: {c2}");
                continue;
            }
            return false;  
        }
        return true;
    }
}
