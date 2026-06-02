using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
