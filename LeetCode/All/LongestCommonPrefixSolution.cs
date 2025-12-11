using System;

namespace LeetCode.All;

public class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var shortestStrLen = int.MaxValue;
        var shortestStr = string.Empty;
        for (int i = 0; i < strs.Length; i++)
        {
            if(shortestStrLen > strs[i].Length)
            {
                shortestStrLen = strs[i].Length;
                shortestStr = strs[i];
            }
        }

        string prefix = string.Empty;
        for (int i = 0; i < shortestStrLen; i++)
        {
            var c = shortestStr[i];
            for (int j = 0; j < strs.Length; j++)
            {
                if(strs[j][i] != c)
                {
                    return prefix;
                }
            }
            prefix += c;
        }

        return prefix;
    }
}
