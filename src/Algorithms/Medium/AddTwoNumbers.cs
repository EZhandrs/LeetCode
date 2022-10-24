namespace Algorithms.Medium
{
    public static class AddTwoNumbers
    {
        public static ListNode Add(ListNode l1, ListNode l2)
        {
            var result = new ListNode();
            var last = result;

            while (last != null)
            {
                if (l1 != null)
                {
                    last.val += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    last.val += l2.val;
                    l2 = l2.next;
                }

                if (last.val > 9)
                {
                    last.val -= 10;
                    last.next = new ListNode(1);
                }
                else if (l1 != null || l2 != null)
                {
                    last.next = new ListNode();
                }

                last = last.next;
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