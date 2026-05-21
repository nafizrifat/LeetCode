//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/ransom-note/
//-----------------------------------------------------------------------------

namespace LeetCode._0331_0600
{
    public class _383_RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
                return false;

            Dictionary<char, int> dicRansomNote = new Dictionary<char, int>();

            foreach (char mc in magazine)
            {
                if (dicRansomNote.ContainsKey(mc))
                {
                    dicRansomNote[mc]++;
                }
                else
                {
                    dicRansomNote.Add(mc, 1);
                }
            }

            foreach (char c in ransomNote)
            {
                if (dicRansomNote.ContainsKey(c))
                {
                    if (dicRansomNote[c] == 1)
                    {
                        dicRansomNote.Remove(c);
                    }
                    else
                    {
                        dicRansomNote[c]--;
                    }
                }
                else { return false; }
            }

            return true;
        }
    }
}
