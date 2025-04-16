using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    public static class Helper
    {
        public static bool AreEqual(ListNode l1, ListNode l2)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val)
                    return false;
                l1 = l1.next;
                l2 = l2.next;
            }
            return l1 == null && l2 == null;
        }
    }
}
