//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/intersection-of-two-arrays/
// Algo Used: HashSet
// Pattern: Set Lookup + Unique Result
//
// Main Concept:
// Store all numbers from the first array in a HashSet, then check which
// numbers from the second array also exist in that set.
//
// Approach:
// 1. Add all numbers from nums1 into a HashSet.
// 2. Create another HashSet to store the common numbers.
// 3. Loop through each number in nums2.
// 4. If the number exists in the first HashSet, add it to the result set.
// 5. Use a HashSet for the result so duplicate values are stored only once.
// 6. Convert the result HashSet to an array and return it.
//
// Edge Cases:
// 1. The arrays have no common numbers.
// 2. The arrays contain duplicate values.
// 3. All numbers are common between both arrays.
// 4. One array contains only one number.
// 5. The arrays contain negative numbers.
//
// Time Complexity: O(n + m)
// Space Complexity: O(n + m)
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
