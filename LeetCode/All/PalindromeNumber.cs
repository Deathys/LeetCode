using System;

namespace LeetCode.All;

public class PalindromeNumber
{
    public bool IsPalindrome(int x) 
    {
        var xStr = x.ToString();
        var xStrChars = xStr.ToCharArray();
        Array.Reverse(xStrChars);
        var xStrRev = new string(xStrChars);
        return xStr == xStrRev;
    }
}
