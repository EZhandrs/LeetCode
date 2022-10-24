using System.Collections.Generic;

namespace Algorithms.Medium
{
    public static class SubarraySumEqualsK
    {
        public static int SubarraySum(int[] nums, int k)
        {
            var sum = 0;
            var count = 0;

            var map = new Dictionary<int, int>(nums.Length / 2);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (sum == k)
                    count++;

                if (map.ContainsKey(sum - k))
                    count += map[sum - k];

                if (map.ContainsKey(sum))
                {
                    map[sum] += 1;
                }
                else
                {
                    map.Add(sum, 1);
                }
            }

            return count;
        }
    }
}