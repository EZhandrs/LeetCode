using Xunit;

namespace AlgorithmsTest.Easy
{
    public class MergeTwoSortedLists
    {
        [Theory]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        [InlineData(new int[] { }, new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { 1, 3, 4 }, new int[] { 1, 2, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { 1, 3 }, new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 2, 4 }, new int[] { 1, 3 }, new int[] { 1, 2, 3, 4 })]
        public void Execute(int[] l1, int[] l2, int[] expected)
        {
            var list1 = GetListNode(l1);
            var list2 = GetListNode(l2);
            var expectedList = GetListNode(expected);

            var actual = Algorithms.Easy.MergeTwoSortedLists.MergeTwoLists(list1, list2);

            while (expectedList != null && actual != null)
            {
                Assert.Equal(expectedList.val, actual.val);

                actual = actual.next;
                expectedList = expectedList.next;
            }

            Assert.Null(actual);
            Assert.Null(expectedList);
        }

        private static Algorithms.Easy.MergeTwoSortedLists.ListNode GetListNode(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            var list = new Algorithms.Easy.MergeTwoSortedLists.ListNode(nums[nums.Length - 1]);

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                list = new Algorithms.Easy.MergeTwoSortedLists.ListNode(nums[i], list);
            }

            return list;
        }
    }
}