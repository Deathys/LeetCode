using System;
using LeetCode.All.Greatest_Sum_Divisible_by_Three;

namespace LeetCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            var res = Greatest_Sum_Divisible_by_Three.MaxSumDivThree(new int[] { 3, 6, 5, 1, 8 });    
            Console.WriteLine(res);
        }
    }
}