
namespace LeetCode.All.Greatest_Sum_Divisible_by_Three;

public static class Greatest_Sum_Divisible_by_Three {
    public static int MaxSumDivThree(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++) {
            var isDev = (nums[i] % 3) == 0;
            if(isDev) {
                sum += nums[i];
            }
        }
        return sum;
    }
}