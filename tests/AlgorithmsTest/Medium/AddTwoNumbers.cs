using Xunit;

namespace AlgorithmsTest.Medium
{
    public class AddTwoNumbers
    {
        [Theory]
        [InlineData(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 0 }, new int[] { 9 }, new int[] { 9 })]
        [InlineData(new int[] { 1 }, new int[] { 9 }, new int[] { 0, 1 })]
        [InlineData(new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 2, 2 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 }, new int[] { 2, 4 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 2, 4, 3 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 2, 4, 3 })]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [InlineData(new int[] { 1, 9, 9 }, new int[] { 1, 2, 3 }, new int[] { 2, 1, 3, 1 })]
        [InlineData(new int[] { 9, 9, 9 }, new int[] { 1, 2, 3 }, new int[] { 0, 2, 3, 1 })]
        [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void Execute(int[] l1, int[] l2, int[] expected)
        {
            var list1 = GetListNode(l1);
            var list2 = GetListNode(l2);
            var expectedList = GetListNode(expected);

            var actual = Algorithms.Medium.AddTwoNumbers.Add(list1, list2);

            while (expectedList != null && actual != null)
            {
                Assert.Equal(expectedList.val, actual.val);

                actual = actual.next;
                expectedList = expectedList.next;
            }

            Assert.Null(actual);
            Assert.Null(expectedList);
        }

        private static Algorithms.Medium.AddTwoNumbers.ListNode GetListNode(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            var list = new Algorithms.Medium.AddTwoNumbers.ListNode(nums[nums.Length - 1]);

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                list = new Algorithms.Medium.AddTwoNumbers.ListNode(nums[i], list);
            }

            return list;
        }
    }
}