public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numCounts = new Dictionary<int, int>();
        foreach(int n in nums)
        {
            if(!numCounts.ContainsKey(n))
                numCounts.Add(n, 0);

            numCounts[n] = numCounts[n] + 1;
        }

        List<int>[] countNums = new List<int>[10001];
        foreach(var kvp in numCounts)
        {
            if(countNums[kvp.Value] == null)
                countNums[kvp.Value] = new List<int>();
            
            countNums[kvp.Value].Add(kvp.Key);
        }

        int[] answer = new int[k];
        for(int i = 10000; i >= 0; i --)
        {
            if(k == 0)
                break;
            if(countNums[i] == null)
                continue;
            foreach(int n in countNums[i])
                answer[--k] = n;
        }

        return answer;
    }
}
