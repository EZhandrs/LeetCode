namespace Algorithms.Easy
{
    public static class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            var minIndex = 0;
            var maxIndex = nums.Length - 1;

            while (minIndex != maxIndex)
            {
                var index = (minIndex + maxIndex) / 2;

                if (nums[index] == target)
                {
                    return index;
                }
                else if (nums[index] > target)
                {
                    maxIndex = index;
                }
                else
                {
                    minIndex = index + 1;
                }
            }

            return nums[minIndex] < target ? minIndex + 1 : minIndex;
        }
    }
}