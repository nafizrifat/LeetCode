//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/valid-anagram/description/
//-----------------------------------------------------------------------------

namespace LeetCode._0001_0300
{
    public class _169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            //int ret= -1;
            //int majorityCount = nums.Length / 2;

            //Dictionary<int, int> dNums = new Dictionary<int, int>();

            //foreach (int x in nums)
            //{
            //    if (dNums.ContainsKey(x))
            //    {
            //        dNums[x]++;
            //    }
            //    else
            //    {
            //        dNums.Add(x, 1);
            //    }

            //    if (dNums[x] > majorityCount)
            //        ret = x;
            //}

            //return ret;

            int majorityCount = nums.Length / 2;

            Dictionary<int, int> numCounts = new Dictionary<int, int>();

            foreach (int x in nums)
            {
                if (numCounts.ContainsKey(x))
                {
                    numCounts[x]++;
                }
                else
                {
                    numCounts.Add(x, 1);
                }

                if (numCounts[x] > majorityCount)
                    return x;
            }

            return -1;
        }
    }
}
