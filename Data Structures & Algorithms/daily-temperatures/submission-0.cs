public class Day {
    public int value;
    public int idx;

    public Day(int value, int idx){
        this.value = value;
        this.idx = idx;
    }
}
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<Day>();
        
        int[] intervals = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i ++){
            var day = new Day(temperatures[i], i);

            if(stack.Count == 0 || stack.Peek().value >= day.value){
                stack.Push(day);
                continue;
            }

            while(stack.Count > 0 && stack.Peek().value < day.value){
                var prevDay = stack.Pop();
                intervals[prevDay.idx] = day.idx - prevDay.idx;
            }
            stack.Push(day);
        }
        return intervals;
    }
}
