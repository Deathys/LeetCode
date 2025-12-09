using System;

namespace LeetCode.All;

public class ReverseInteger
{
    public int Reverse(int x) 
    {
        string xStr = x.ToString();
        string sign = string.Empty;
        if(xStr.StartsWith("-"))
        {
            sign = "-";
            xStr = xStr[1..];
        }
        char[] xChars = xStr.ToCharArray();
        Array.Reverse(xChars);
        string revXStr = sign + new string(xChars);
        if(int.TryParse(revXStr, out var revX))
        {
            return revX;
        }

        return 0;
    }
}
