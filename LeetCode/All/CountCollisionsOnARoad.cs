using System;

namespace LeetCode.All;

public class CountCollisionsOnARoad
{
    public int CountCollisions(string directions)
    {
        int left = 0;
        int right = directions.Length - 1;

        // Skip all 'L' at the beginning (they move away to the left)
        while (left < directions.Length && directions[left] == 'L')
        {
            left++;
        }

        // Skip all 'R' at the end (they move away to the right)
        while (right >= 0 && directions[right] == 'R')
        {
            right--;
        }

        // Count collisions: all 'R' and 'L' between left and right will collide
        int collisions = 0;
        for (int i = left; i <= right; i++)
        {
            if (directions[i] == 'R' || directions[i] == 'L')
            {
                collisions++;
            }
        }

        return collisions;
    }
}
