//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/first-unique-character-in-a-string/
// Algo Used: Dictionary
// Pattern: Frequency Counting
//
// Main Concept:
// Count how many times each character appears, then find the first character
// whose frequency is exactly 1.
//
// Approach:
// 1. Use Dictionary<char, int> to count each character in the string.
// 2. Loop through the string again from left to right.
// 3. Check the frequency of each character in the dictionary.
// 4. Return the first index whose character count is 1.
// 5. Return -1 if no unique character exists.
//
// Edge Cases:
// 1. The string contains only one character.
// 2. Every character appears more than once.
// 3. The unique character appears at the beginning or end.
//
// Time Complexity: O(n)
// Space Complexity: O(k), where k is the number of unique characters.
//-----------------------------------------------------------------------------

namespace LeetCode._0301_0600
{
    public class _387_FirstUniqueCharacterInaString
    {
        public int FirstUniqChar(string s)
        {

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }

            //foreach (char c in s)
            //{
            //    if (dic.ContainsKey(c) && (dic[c] == 1))
            //    {
            //        return s.IndexOf(c);
            //    }
            //}


            //Because IndexOf() scans the string again from the beginning.
            //So although your solution looks like O(n),
            //technically it can become worse due to repeated searches.
            // Find first unique char
            for (int i = 0; i < s.Length; i++)
            {
                if (dic[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;

            //Optimization using ARRAY
            //int[] freq = new int[26];

            //foreach (char c in s)
            //{
            //    //Using character ASCII/Unicode values to convert letters into array indexes.
            //    //if c='b'
            //    //ASCII valus of b = 98 & a = 97
            //    // 'b' - 'a' => 98-97 => 1
            //    // so index 1 of the Array
            //    freq[c - 'a']++;
            //}

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (freq[s[i] - 'a'] == 1)
            //    {
            //        return i;
            //    }
            //}

            //return -1;
        }
    }
}
