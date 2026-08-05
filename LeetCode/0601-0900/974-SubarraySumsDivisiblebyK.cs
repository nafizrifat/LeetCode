//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/subarray-sums-divisible-by-k/description/
// Algo Used: Dictionary + Prefix Sum
// Pattern: Prefix Sum Remainder + Frequency Counting
//
// Main Concept:
// If two prefix sums have the same remainder when divided by k, the sum of
// the elements between them is divisible by k.
//
// Approach:
// 1. Use a running prefix sum while traversing the array.
// 2. Calculate the remainder of the prefix sum divided by k.
// 3. Convert a negative remainder into a positive remainder by adding k.
// 4. Use Dictionary<int, int> to store how many times each remainder appears.
// 5. Initialize remainder 0 with frequency 1 to handle subarrays
//    starting from index 0.
// 6. If the current remainder already exists, add its frequency
//    to the result count.
// 7. Store or update the frequency of the current remainder.
// 8. Return the total number of subarrays whose sum is divisible by k.
//
// Edge Cases:
// 1. The valid subarray starts at index 0.
// 2. The array contains negative numbers or zeros.
// 3. The prefix sum produces a negative remainder.
// 4. The same remainder appears multiple times.
// 5. No subarray sum is divisible by k.
//
// Time Complexity: O(n)
// Space Complexity: O(k)
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
