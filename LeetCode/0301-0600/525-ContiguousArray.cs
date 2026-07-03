//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/contiguous-array/description/
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
