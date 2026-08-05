//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/contiguous-array/description/
// Algo Used: Dictionary + Prefix Sum
// Pattern: Prefix Sum + First Occurrence
//
// Main Concept:
// Treat 0 as -1 and 1 as +1. If the same prefix sum appears again, the
// elements between those two positions contain an equal number of 0s and 1s.
//
// Approach:
// 1. Use a running prefix sum.
// 2. Add +1 when the current number is 1.
// 3. Add -1 when the current number is 0.
// 4. Store the first index where each prefix sum appears.
// 5. If the same prefix sum appears again, calculate the distance between
//    the current index and its first occurrence.
// 6. Keep track of the maximum distance.
// 7. Initialize prefix sum 0 at index -1 to handle valid subarrays
//    starting from index 0.
//
// Edge Cases:
// 1. The entire array contains an equal number of 0s and 1s.
// 2. The array contains only 0s or only 1s.
// 3. The longest valid subarray starts at index 0.
// 4. The same prefix sum appears multiple times.
//
// Time Complexity: O(n)
// Space Complexity: O(n)
//-----------------------------------------------------------------------------

namespace LeetCode._0301_0600
{
    public class _525_ContiguousArray
    {
        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> firstSeen = new();

            firstSeen[0] = -1;

            int balance = 0;
            int maxLength = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    balance--;
                }
                else
                {
                    balance++;
                }

                if (firstSeen.ContainsKey(balance))
                {
                    int previousIndex = firstSeen[balance];
                    int currentLength = i - previousIndex;

                    maxLength = Math.Max(maxLength, currentLength);
                }
                else
                {
                    firstSeen[balance] = i;
                }
            }

            return maxLength;
        }
    }
}
