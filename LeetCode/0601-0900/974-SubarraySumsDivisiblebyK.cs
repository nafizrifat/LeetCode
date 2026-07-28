//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/subarray-sums-divisible-by-k/description/
//-----------------------------------------------------------------------------

namespace LeetCode._0601_0900
{
    public class _974_SubarraySumsDivisiblebyK
    {
        public int SubarraysDivByK(int[] nums, int k)
        {
            int count = 0;
            int prefixSum = 0;

            // remainderCount[r] = how many times remainder r appeared before
            int[] remainderCount = new int[k];

            // Empty prefix sum has remainder 0
            remainderCount[0] = 1;

            foreach (int num in nums)
            {
                prefixSum += num;

                // Handle negative numbers also
                int remainder = prefixSum % k;

                if (remainder < 0)
                {
                    remainder += k;
                }

                // If same remainder appeared before,
                // subarray between those two prefix sums is divisible by k
                count += remainderCount[remainder];

                // Store current remainder
                remainderCount[remainder]++;
            }

            return count;
        }
    }
}
