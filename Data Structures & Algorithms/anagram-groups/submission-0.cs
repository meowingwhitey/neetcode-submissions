public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var groupDict = new Dictionary<string, List<string>>();

        foreach(string s in strs)
        {
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            string sorted = new string(arr);

            if(!groupDict.ContainsKey(sorted))
                groupDict.Add(sorted, new List<string>());

            groupDict[sorted].Add(s);
        }

        var results = new List<List<string>>();
        foreach(var kvp in groupDict)
        {
            results.Add(kvp.Value);
        }

        return results;
    }
}
