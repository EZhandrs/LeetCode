using System;

namespace Algorithms.Medium
{
    public static class JumpGameII
    {
        public static int Jump(int[] nums)
        {
            var jumps = 0;
            var farthest = 0;
            var currJumpEnd = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                farthest = Math.Max(farthest, nums[i] + i);

                if (i == currJumpEnd)
                {
                    currJumpEnd = farthest;
                    ++jumps;
                }
            }

            return jumps;
        }
    }
}