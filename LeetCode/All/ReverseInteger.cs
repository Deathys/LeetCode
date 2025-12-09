using System;

namespace LeetCode.All;

public class ReverseInteger
{
    public int Reverse2(int x) 
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

    public int Reverse(int x) 
    {
        int result = 0;
        
        while (x != 0) 
        {
            int digit = x % 10;
            x /= 10;
            
            // Check for overflow before multiplying
            if (result > int.MaxValue / 10 || result < int.MinValue / 10) 
            {
                return 0;
            }
            
            result = result * 10 + digit;
        }
        
        return result;
    }
}
