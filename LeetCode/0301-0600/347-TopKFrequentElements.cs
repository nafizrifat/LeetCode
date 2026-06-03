//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/top-k-frequent-elements/
// Algo Used: Dictionary + Bucket Sort
//
// Main Concept:
// Count each number's frequency, then place numbers into buckets where
// bucket index = frequency.
//
// Approach:
// 1. Use Dictionary<int, int> to count frequency of each number.
// 2. Create buckets of size nums.Length + 1 because max frequency can be nums.Length.
// 3. Put each number into buckets[count].
// 4. Traverse buckets from high frequency to low frequency.
// 5. Add numbers to result until result.Count == k.
//
// Time Complexity: O(n)
// Space Complexity: O(n)
//-----------------------------------------------------------------------------

using System.Xml.Linq;

namespace LeetCode._0301_0600
{
    public class _347_TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                    freq.Add(num, 1);
                }
            }
            //// Sorts descending, takes the first k elements, and extracts only the keys
            //int[] topKVlues = freq
            //    .OrderByDescending(pair => pair.Value)
            //    .Select(pair => pair.Key)
            //    .Take(k)
            //    .ToArray();

            ////O(n log n)
            ////where m is the number of unique elements.
            ////In the worst case, if all numbers are unique, m = n, so time complexity becomes:

            //return topKVlues;

            List<int>[] buckets = new List<int>[nums.Length + 1];

            foreach (KeyValuePair<int, int> pair in freq)
            {
                int number = pair.Key;
                int count = pair.Value;

                if (buckets[count] == null)
                {
                    buckets[count] = new List<int>();
                }

                buckets[count].Add(number);
            }

            List<int> result = new List<int>();

            for (int i = buckets.Length - 1; i >= 0; i--)
            {
                if (buckets[i] != null)
                {
                    foreach (int number in buckets[i])
                    {
                        result.Add(number);

                        if (result.Count == k)
                        {
                            return result.ToArray();
                        }
                    }
                }
            }

            return result.ToArray();



        }
    }
}
