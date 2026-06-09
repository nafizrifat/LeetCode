//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/longest-consecutive-sequence/description/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode._0001_0300
{
    public class _128_LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            //if(nums == null || nums.Length == 0)
            //    return 0;

            //int longest = 1;
            //int currentLength = 1;

            ////HashSet<int> map = new HashSet<int>(nums);
            //int[] numsArray = nums.OrderBy(x => x).ToArray(); ;

            //for (int i = 0; i < numsArray.Length; i++) {
            //    //if (i + 1 >= numsArray.Length)
            //    //    return ret;

            //    if (numsArray[i] == numsArray[i + 1])
            //        continue;

            //    if (numsArray[i+1] == numsArray[i] + 1)
            //        currentLength++;
            //    else
            //        currentLength = 1;

            //    longest = Math.Max(longest, currentLength);


            //}
            //return longest;

            if (nums == null || nums.Length == 0)
                return 0;

            HashSet<int> set = new HashSet<int>(nums);

            int longest = 0;

            foreach (int num in set) { 

                if(!set.Contains(num-1))
                {
                    int currentNum = num;
                    int currentLength = 1;

                    while (set.Contains(currentNum + 1))
                    {
                        currentLength++;
                        currentNum++;
                    }
                    longest = Math.Max(longest, currentLength);
                }

            }
            return longest;
        }
    }
}
