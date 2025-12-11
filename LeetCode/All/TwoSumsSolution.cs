using System;

namespace LeetCode.All;

public class TwoSumsSolution
{
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int c = target - nums[i];
                if (map.ContainsKey(c)) 
                {
                    return [map[c], i];
                }
                map[nums[i]] = i;
            }
        throw new Exception("No two sum solution");
    }
}
