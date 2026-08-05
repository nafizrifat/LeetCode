//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/sort-characters-by-frequency/
// Algo Used: Dictionary + Bucket Sort
// Pattern: Frequency Counting
//
// Main Concept:
// Count each character's frequency, then place characters into buckets where
// the bucket index represents the character's frequency.
//
// Approach:
// 1. Use Dictionary<char, int> to count each character in the string.
// 2. Create buckets of size s.Length + 1 because the maximum frequency
//    of a character can be s.Length.
// 3. Place each character into buckets[frequency].
// 4. Traverse the buckets from highest frequency to lowest frequency.
// 5. Add each character to the result as many times as its frequency.
// 6. Return the completed string.
//
// Edge Cases:
// 1. The string contains only one character.
// 2. Every character has the same frequency.
// 3. One character appears more frequently than all other characters.
// 4. Uppercase and lowercase characters are treated as different characters.
//
// Time Complexity: O(n)
// Space Complexity: O(n)
//-----------------------------------------------------------------------------


using System.Text;

namespace LeetCode._0301_0600
{
    public class _451_SortCharactersByFrequency
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency.Add(c, 1);
                }
            }

            // Highest frequency should come first
            var sortedFrequency = frequency
                .OrderByDescending(x => x.Value);


            ////USING string += string concatenation
            //string result = "";

            //foreach (var item in sortedFrequency)
            //{
            //    char character = item.Key;
            //    int count = item.Value;

            //    for (int i = 0; i < count; i++)
            //    {
            //        result += character;
            //    }
            //}



            // Use StringBuilder to build the final result
            // StringBuilder is better than string += because it is more efficient
            StringBuilder result = new StringBuilder();

            // For each character, repeat it based on its frequency
            foreach (var item in sortedFrequency)
            {
                char character = item.Key;
                int count = item.Value;

                for (int i = 0; i < count; i++)
                {
                    result.Append(character);
                }
            }

            ////NO NESTED LOOP
            ////Append() with two parameters
            ////Append(char value, int repeatCount)
            //foreach (var item in sortedFrequency)
            //{
            //    result.Append(new string(item.Key, item.Value));
            //}

            // Convert StringBuilder to string and return
            return result.ToString();

        }
    }
}
