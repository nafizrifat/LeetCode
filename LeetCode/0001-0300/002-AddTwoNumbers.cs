//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 31.3 MB
// Link: https://leetcode.com/problems/add-two-numbers/description/
//-----------------------------------------------------------------------------

namespace LeetCode._0001_0300
{
    public class _002_AddTwoNumbers
    {
        public _002_AddTwoNumbers()
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));
            var result = AddTwoNumbers(l1, l2);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode outputList = new ListNode(0);
            ListNode finalOutput = outputList;
            int carry = 0;
            int x = 0;
            int y = 0;
            int totalSum = 0;

            ListNode firstList = l1;
            ListNode secondList = l2;

            while (firstList != null || secondList != null)
            {
                x = (firstList != null) ? firstList.val : 0;
                y = (secondList != null) ? secondList.val : 0;

                totalSum = x + y + carry;
                carry = totalSum / 10;

                outputList.next = new ListNode(totalSum % 10);


                outputList = outputList.next;

                if (firstList != null) firstList = firstList.next;
                if (secondList != null) secondList = secondList.next;
            }
            if (carry > 0)
            {
                outputList.next = new ListNode(carry);
            }
            return finalOutput.next;
        }
    }
}
