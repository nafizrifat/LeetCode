//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/intersection-of-two-arrays/
//-----------------------------------------------------------------------------

namespace LeetCode._0301_0600
{
    public class _349_IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            //HashSet<int> dN1 = new HashSet<int>();

            //foreach (int i in nums1)
            //{
            //    if (!dN1.Contains(i))
            //    {
            //        dN1.Add(i);
            //    }
            //}

            //List<int> returnList = new List<int>();
            //foreach (int i in nums2)
            //{
            //    if (dN1.Contains(i))
            //    {
            //        //Because List.Contains() is O(n).
            //        //Better use another HashSet for the result.
            //        if (!returnList.Contains(i))
            //        {
            //            returnList.Add(i);
            //        }
            //    }
            //}
            //return returnList.ToArray();

            //HashSet automatically keeps only unique values.
            HashSet<int> set1 = new HashSet<int>(nums1); 
            HashSet<int> result = new HashSet<int>();

            foreach (int num in nums2)
            {
                if (set1.Contains(num))
                {
                    result.Add(num);
                }
            }

            return result.ToArray();

        }
    }
}
