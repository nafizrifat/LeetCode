//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/intersection-of-two-arrays-ii/
//-----------------------------------------------------------------------------

namespace LeetCode._0301_0600
{
    public class _350_IntersectionOfTwoArrays2
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return Intersect(nums2, nums1);
            }

            Dictionary<int, int> dNums1 = new Dictionary<int, int>();

            foreach (int i in nums1)
            {
                if (dNums1.ContainsKey(i)) dNums1[i]++;
                else dNums1.Add(i, 1);
            }

            List<int> returnList = new List<int>();

            foreach (int i in nums2)
            {
                if (dNums1.ContainsKey(i)&& dNums1[i]>0)
                {
                    dNums1[i]--;
                    returnList.Add(i);
                }

            }
            return returnList.ToArray();
        }
    }
}
