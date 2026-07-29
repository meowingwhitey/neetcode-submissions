public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length)
            return false;

        Dictionary<char, int> dictS = new Dictionary<char, int>();
        
        foreach(char c in s)
        {
            if(!dictS.ContainsKey(c)) 
                dictS.Add(c, 0);
            dictS[c] = dictS[c] + 1;
        }

        Dictionary<char, int> dictT = new Dictionary<char, int>();

        foreach(char c in t)
        {
            if(!dictT.ContainsKey(c)) dictT.Add(c, 0);
            dictT[c] = dictT[c] + 1;
        }

        foreach(KeyValuePair<char, int> kvp in dictS)
        {
            if(!dictT.ContainsKey(kvp.Key) || dictT[kvp.Key] != kvp.Value)
                return false;
        }
        return true;
    }
}
