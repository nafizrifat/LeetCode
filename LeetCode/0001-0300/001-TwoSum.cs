//-----------------------------------------------------------------------------
// Runtime: 1ms
// Memory Usage: 48.96 MB
// Link: https://leetcode.com/problems/two-sum/
//-----------------------------------------------------------------------------

namespace LeetCode._0001_0300
{
    public class _001_TwoSum
    {
        public _001_TwoSum()
        {

        }

        public int[] TwoSum(int[] nums, int target)
        {
            ////Start: Solution using Two For Loop
            ////Time Complexity: O(n^2) due to two for loops
            //int i, j;
            //for (i = 0; i < nums.Length; i++)
            //    for (j = 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target & i != j)
            //        {
            //            return new[] { i, j };
            //        }
            //    }

            //return null;
            ////End: Solution using Two For Loop
            ///


            //Start: Solution using Dictionary
            //Time Complexity: O(n) due to one for loop

            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                //Calculate the complement needed to reach the target
                int complement = target - nums[i];

                //Check if the complement is already in the Dictionary
                if (numDict.ContainsKey(complement))
                {

                    //if found, return the indexes as an array
                    return new int[] { numDict[complement], i };
                }

                //if not in the dictionaly then Add it
                if (!numDict.ContainsKey(complement))
                {
                    numDict[nums[i]] = i;
                }
            }
            //if no match found return empty array
            return new int[] { };
        }
    }
}
