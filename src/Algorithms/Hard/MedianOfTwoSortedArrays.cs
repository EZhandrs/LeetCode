using System;

namespace Algorithms.Hard
{
    public static class MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;

            if (m > n)
                return FindMedianSortedArrays(nums2, nums1);
            else if (n == 0)
                return 0;

            int start = 0, end = m;

            while (start <= end)
            {
                int cut1 = (start + end) / 2;
                int cut2 = (m + n + 1) / 2 - cut1;

                int l1 = (cut1 == 0) ? int.MinValue : nums1[cut1 - 1];
                int l2 = (cut2 == 0) ? int.MinValue : nums2[cut2 - 1];

                int r1 = (cut1 == m) ? int.MaxValue : nums1[cut1];
                int r2 = (cut2 == n) ? int.MaxValue : nums2[cut2];

                if (l1 <= r2 && l2 <= r1)
                {
                    if ((m + n) % 2 == 0)
                    {
                        return (Math.Max(l1, l2) + Math.Min(r1, r2)) / 2.0;
                    }

                    return Math.Max(l1, l2);
                }
                else if (l1 > r2)
                {
                    end = cut1 - 1;
                }
                else
                {
                    start = cut1 + 1;
                }
            }

            return -1;
        }
    }
}
