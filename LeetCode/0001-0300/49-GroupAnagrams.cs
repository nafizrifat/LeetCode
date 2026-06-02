//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/group-anagrams/
//-----------------------------------------------------------------------------

namespace LeetCode._0001_0300
{
    public class _49_GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {

                // Convert word to character array
                char[] c = str.ToCharArray();

                // Sort characters alphabetically
                Array.Sort(c);

                // Create KEY - Convert sorted characters back to string
                string key = new string(c);
                //string key =c.ToString();

                // If this key does not exist, create a new group
                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }

                // Add original word to the correct group
                map[key].Add(str);

            }

            // Return only the grouped words

            //// Traditional loop
            //IList<IList<string>> result = new List<IList<string>>();
            //foreach (List<string> group in map.Values)
            //{
            //    result.Add(group);
            //}
            //return result;


            // Shorter LINQ way.
            return map.Values.ToList<IList<string>>();
        }
    }
}
