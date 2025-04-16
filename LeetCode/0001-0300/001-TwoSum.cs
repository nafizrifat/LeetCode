//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 31.3 MB
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
            int i, j;
            for (i = 0; i < nums.Length; i++)
                for (j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target & i != j)
                    {
                        return new[] { i, j };
                    }
                }

            return null;
        }
    }
}
