//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/4sum-ii/description/
// Algo Used: Dictionary
// Pattern: Pair Sum + Frequency Counting
//
// Main Concept:
// Store the frequency of every possible sum from nums1 and nums2, then check
// how many matching opposite sums can be formed from nums3 and nums4.
//
// Approach:
// 1. Use Dictionary<int, int> to store the frequency of each sum from
//    nums1[i] + nums2[j].
// 2. Loop through every pair from nums3 and nums4.
// 3. Calculate the required opposite sum: -(nums3[k] + nums4[l]).
// 4. If the opposite sum exists in the dictionary, add its frequency
//    to the result count.
// 5. Return the total number of valid tuples.
//
// Edge Cases:
// 1. The arrays contain duplicate values.
// 2. The arrays contain negative numbers and zeros.
// 3. The same pair sum can occur multiple times.
// 4. No four numbers produce a total sum of zero.
//
// Time Complexity: O(n²)
// Space Complexity: O(n²)
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
