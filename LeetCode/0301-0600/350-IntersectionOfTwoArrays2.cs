//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/intersection-of-two-arrays-ii/
// Algo Used: Dictionary
// Pattern: Frequency Counting
//
// Main Concept:
// Count each number's frequency in the first array, then use those counts
// while finding matching numbers in the second array.
//
// Approach:
// 1. Use Dictionary<int, int> to count the frequency of each number in nums1.
// 2. Create a list to store the intersection.
// 3. Loop through each number in nums2.
// 4. If the number exists in the dictionary and its count is greater than 0,
//    add it to the result.
// 5. Decrease the number's frequency after using it.
// 6. Convert the result list to an array and return it.
//
// Edge Cases:
// 1. The arrays have no common numbers.
// 2. The arrays contain duplicate values.
// 3. One number appears more times in one array than in the other.
// 4. All numbers are common between both arrays.
// 5. The arrays contain negative numbers.
//
// Time Complexity: O(n + m)
// Space Complexity: O(n)
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
