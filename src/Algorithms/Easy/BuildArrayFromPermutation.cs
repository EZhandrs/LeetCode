namespace Algorithms.Easy
{
    //https://leetcode.com/problems/build-array-from-permutation
    public static class BuildArrayFromPermutation
    {
        public static int[] Build(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++) nums[i] |= (nums[nums[i]] << 16);
            for (int i = 0; i < n; i++) nums[i] >>= 16;

            return nums;
        }
    }
}