public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        var filtered = new List<char>();

        foreach(char c in s)
        {
            char fc = c;
            if(fc >= 'A' && fc <= 'Z')
                fc = (char)(fc + ('a' - 'A'));
            if(fc >= 'a' && fc <='z' || fc >= '0' && fc <= '9')
                filtered.Add(fc);   
        }

        for(int i = 0, j = filtered.Count - 1; 
            i < filtered.Count / 2; i ++, j --)
        {
            if(filtered[i] != filtered[j])
                return false;
        }
        return true;
    }
}
