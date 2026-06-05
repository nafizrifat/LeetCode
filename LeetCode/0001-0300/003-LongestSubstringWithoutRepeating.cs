//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode._0001_0300
{
    public class _003_LongestSubstringWithoutRepeating
    {
        public int LengthOfLongestSubstring(string s)
        {
            //// Convert to char array
            //char[] characters = s.ToCharArray();

            //HashSet<char> seen = new HashSet<char>();
            //int maxlength = 0;

            //for (int i = 0; i < characters.Length; i++) {

            //    if (!seen.Add(characters[i])) {
            //        int currentMaxlength = seen.Count;
            //        if(currentMaxlength> maxlength)
            //            maxlength = currentMaxlength;
            //        seen = new HashSet<char>();
            //    }            
            //}

            //return maxlength;


            HashSet<char> set = new HashSet<char>();

            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char current = s[right];
                while (set.Contains(current))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(current);
                int currentLength = right - left + 1;
                maxLength = Math.Max(maxLength, currentLength);
            }

            return maxLength;
        }
    }
}
