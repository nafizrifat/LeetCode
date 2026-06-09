//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/4sum-ii/description/
//-----------------------------------------------------------------------------

namespace LeetCode._0301_0600
{
    public class _454_4SumII
    {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            int count = 0;
            Dictionary<int, int> sumCount = new Dictionary<int, int>();

            foreach (int i in nums1)
            {
                foreach (int j in nums2)
                {
                    int sum = i + j;

                    if (sumCount.ContainsKey(sum))
                    {
                        sumCount[sum]++;
                    }
                    else
                        sumCount.Add(sum, 1);
                        //sumCount[sum] = 1;
                }
            }

            foreach (int i in nums3)
            {
                foreach (int j in nums4)
                {
                    int sum = i + j;
                    int sumNeeded = -sum;

                    if (sumCount.ContainsKey(sumNeeded))
                    {
                        count += sumCount[sumNeeded];
                    }

                }
            }
            return count;
        }
    }
}
