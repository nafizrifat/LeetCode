//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/subarray-sum-equals-k/description/
//-----------------------------------------------------------------------------

namespace LeetCode._0301_0600
{
    public class _560_SubarraySumEqualsK
    {
        public int SubarraySum(int[] nums, int k)
        {
            //int prefixSum = 0;
            //int count = 0;
            //int[] remainderCount = new int[k];
            //int reminder = 0;
            //// Empty prefix sum has remainder 0
            ////remainderCount[0] = 1;

            //foreach (int num in nums)
            //{
            //    prefixSum += num;

            //    if (prefixSum == k)
            //        count++;
            //    else
            //    {
            //        reminder = prefixSum % k;

            //        count += remainderCount[reminder];
            //        remainderCount[reminder]++;
            //    }
            //}

            //return count;
            int prefixSum = 0;
            int count = 0;

            Dictionary<int, int> prefixSumCount = new()
            {
                [0] = 1
            };

            foreach (int num in nums)
            {
                prefixSum += num;

                //if (prefixSumCount.TryGetValue(prefixSum - k, out int frequency))
                //{
                //    count += frequency;
                //}
                int requiredPrefixSum = prefixSum - k;

                if (prefixSumCount.ContainsKey(requiredPrefixSum))
                {
                    int frequency = prefixSumCount[requiredPrefixSum];
                    count += frequency;
                }

                //prefixSumCount[prefixSum] =
                //    prefixSumCount.GetValueOrDefault(prefixSum) + 1;
                if (prefixSumCount.ContainsKey(prefixSum))
                {
                    prefixSumCount[prefixSum]++;
                }
                else
                {
                    prefixSumCount[prefixSum] = 1;
                }
            }

            return count;
        }
    }
}
