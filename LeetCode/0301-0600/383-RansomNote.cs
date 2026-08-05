//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/ransom-note/
// Algo Used: Dictionary
// Pattern: Frequency Counting
//
// Main Concept:
// Count each character in magazine, then use those counts to check whether
// every character needed for ransomNote is available.
//
// Approach:
// 1. Use Dictionary<char, int> to count the frequency of each character
//    in magazine.
// 2. Loop through each character in ransomNote.
// 3. If the character does not exist in the dictionary or its count is 0,
//    return false.
// 4. Decrease the character's count after using it.
// 5. Return true after all characters in ransomNote are successfully matched.
//
// Edge Cases:
// 1. ransomNote is longer than magazine.
// 2. A required character does not exist in magazine.
// 3. A character exists but does not appear enough times.
// 4. ransomNote and magazine contain repeated characters.
// 5. ransomNote is empty.
//
// Time Complexity: O(n + m)
// Space Complexity: O(k), where k is the number of unique characters.
//-----------------------------------------------------------------------------


namespace LeetCode._0301_0600
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
