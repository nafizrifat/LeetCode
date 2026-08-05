//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/subarray-sum-equals-k/description/
// Algo Used: Dictionary + Prefix Sum
// Pattern: Prefix Sum + Frequency Counting
//
// Main Concept:
// If the current prefix sum is prefixSum, then a previous prefix sum of
// prefixSum - k means the elements between them have a sum equal to k.
//
// Approach:
// 1. Use a running prefix sum while traversing the array.
// 2. Use Dictionary<int, int> to store how many times each prefix sum appears.
// 3. Initialize prefix sum 0 with frequency 1 to handle subarrays
//    starting from index 0.
// 4. For each number, update the running prefix sum.
// 5. Check whether prefixSum - k exists in the dictionary.
// 6. If it exists, add its frequency to the result count.
// 7. Store or update the frequency of the current prefix sum.
// 8. Return the total number of subarrays whose sum equals k.
//
// Edge Cases:
// 1. The valid subarray starts at index 0.
// 2. The array contains negative numbers or zeros.
// 3. Multiple subarrays have the same sum.
// 4. The same prefix sum appears multiple times.
// 5. No subarray has a sum equal to k.
//
// Time Complexity: O(n)
// Space Complexity: O(n)
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
