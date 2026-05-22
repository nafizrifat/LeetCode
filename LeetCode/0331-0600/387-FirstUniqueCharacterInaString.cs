//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/first-unique-character-in-a-string/
//-----------------------------------------------------------------------------
namespace LeetCode._0331_0600
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
