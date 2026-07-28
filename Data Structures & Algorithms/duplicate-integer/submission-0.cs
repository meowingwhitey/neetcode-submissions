public class Solution 
{
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> hs = new HashSet<int>();

        foreach(int n in nums)
        {
            if(hs.Contains(n))
                return true;

            hs.Add(n);
        }
        return false;
    }
}