using System;
using System.Text;

namespace LeetCode.All;

public class ConfusingNumberSolution
{
    public bool ConfusingNumber(int n) 
    {
        if(n == 0) 
            return false;

        char[] map = ['0', '1', '-', '-', '-', '-', '9', '-', '8', '6'];

        var original = n.ToString();
        var rotatedArr = original.ToCharArray();
        Array.Reverse(rotatedArr);
        var reversed = new string(rotatedArr);
        var rotated = new StringBuilder();
        for(int i = 0; i < reversed.Length; i++) 
        {
            byte digit = byte.Parse(reversed[i].ToString());
            if(map[digit] == '-') 
                return false;
            rotated.Append(map[digit]);
        }
        
        return original != rotated.ToString();
    }


}
