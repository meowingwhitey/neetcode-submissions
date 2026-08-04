public class Solution 
{

    public string Encode(IList<string> strs) 
    {
        // change every byte to hex string
        // add separator and combine as one string
        // PROFIT!

        // foreach(string s in strs)
        // {
        //     var hSb = new StringBuilder();
        //     foreach(char c in s)
        //     {
        //         string hex = ((int)c).ToString("X4");
        //         hSb.Append(c);
        //     }
        //     hSb.Append("////");
        // }

        // Encode
        var encodedSb = new StringBuilder();
        foreach(string originalText in strs)
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(originalText);
            string base64Encoded = Convert.ToBase64String(textBytes);
            encodedSb.Append(base64Encoded.ToString() + "/");
        }
        return encodedSb.ToString();
    }

    public List<string> Decode(string s) 
    {
        // divide string by seperator
        // change every hex string to byte
        // PROFIT!
        // var strList = new List<string>();
        // var strSb = new StringBuilder();
        // for(int i = 0; i < s.Length; i += 4)
        // {
        //     var cSb = new StringBuilder();
        //     for(int b = i; b < 4; b ++)
        //         cSb.Append(s[b]);
            
        //     if(cSb == "////")
        //         strList.Append(strSb);

        //     int converted = Convert.ToInt32(cSb, 16);
        //     i
        // }
        // Decode
        string[] encodedStrArr = s.Split('/');
        var decodedStrList = new List<string>();
        foreach(string encodedStr in encodedStrArr)
        {
            // Console.WriteLine($"encodedStr: {encodedStr}");
            byte[] decodedBytes = Convert.FromBase64String(encodedStr);
            string decodedText = Encoding.UTF8.GetString(decodedBytes);
            decodedStrList.Add(decodedText);
        }
        decodedStrList.RemoveAt(decodedStrList.Count - 1); 
        return decodedStrList;
    }
}
