using System.Collections.Generic;

namespace Algorithms.Easy
{
    public static class TwoSum
    {
        public static int[] Indexes(int[] nums, int target)
        {
            var shortage = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (shortage.ContainsKey(nums[i]))
                {
                    return new int[] { shortage[nums[i]], i };
                }

                shortage.TryAdd(target - nums[i], i);
            }

            return null;
        }
    }
}