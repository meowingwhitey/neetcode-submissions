public class Solution {
    public int[] PlusOne(int[] digits) {
        
        var stack = new Stack<int>();

        int carry = 1;
        for(int i = digits.Length - 1; i >= 0; i --) {
            int sum = digits[i] + carry;
            stack.Push(sum % 10);
            if(sum <= 9) {
                carry = 0;
            }
        }

        if(carry == 1)
            stack.Push(1);

        var result = new int[stack.Count];
        
        for(int i = 0; i < result.Length; i ++) {
            result[i] = stack.Pop(); 
        }
            
        return result;
    }
}
