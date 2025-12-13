using System;

namespace LeetCode.All;

public class CouponCodeValidator
{
    private readonly HashSet<string> _validbusinessLines = new HashSet<string>
    {
        "electronics",
        "grocery",
        "pharmacy",
        "restaurant"
    };

    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
    {
        var result = new List<(string code, byte weight)>();
        for (int i = 0; i < code.Length; i++)
        {
            if(!isActive[i])
                continue;

            if(!_validbusinessLines.Contains(businessLine[i]))
                continue;

            if(string.IsNullOrEmpty(code[i]))
                continue;

            if (!code[i].All( c => char.IsLetterOrDigit(c) || c == '_'))
                continue;
            
            var weight  = GetBusinessLineWeight(businessLine[i]);

            result.Add((code[i], weight));
        }

        var sorted = result
            .OrderBy(r => r.weight)
            .ThenBy(r => r.code, StringComparer.Ordinal);

        return sorted.Select(r => r.code).ToList();
    }

    private byte GetBusinessLineWeight(string businessLine)
        => businessLine switch
        {
            "electronics" => 1,
            "grocery" => 2,
            "pharmacy" => 3,
            "restaurant" => 4,
            _ => 0
        };
}
