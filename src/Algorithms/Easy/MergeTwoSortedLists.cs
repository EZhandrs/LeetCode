namespace Algorithms.Easy
{
    public static class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
                return null;

            var result = new ListNode();
            var current = result;

            while (current != null)
            {
                if (list1 != null && list2 != null)
                {
                    if (list1.val < list2.val)
                    {
                        current.val = list1.val;
                        list1 = list1.next;
                    }
                    else
                    {
                        current.val = list2.val;
                        list2 = list2.next;
                    }
                }
                else if (list1 != null)
                {
                    current.val = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    current.val = list2.val;
                    list2 = list2.next;
                }

                if (list1 != null || list2 != null)
                    current.next = new ListNode();

                current = current.next;
            }

            return result;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}