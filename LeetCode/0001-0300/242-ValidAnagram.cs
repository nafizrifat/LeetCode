//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/valid-anagram/description/
//-----------------------------------------------------------------------------
namespace LeetCode._0001_0300
{
    public class _242_ValidAnagram
    {

        public bool IsAnagram(string s, string t)
        {

            //Using Dictionary
            //Dictionary<char, int> sDic = new Dictionary<char, int>();

            ////Build dictonary of char from s and count
            //foreach (char sc in s)
            //{
            //    if (sDic.ContainsKey(sc))
            //    {
            //        sDic[sc] += 1;
            //    }
            //    else
            //    {
            //        sDic.Add(sc, 1);
            //    }
            //}

            ////Check target char if exist with proper count
            //foreach (char tc in t)
            //{
            //    if (!sDic.ContainsKey(tc))
            //    {
            //        return false;
            //    }
            //    if (sDic[tc] == 1)
            //    {
            //        sDic.Remove(tc);
            //    }
            //    else
            //    {
            //        sDic[tc] -= 1;
            //    }
            //}
            //if (sDic.Count == 0)
            //    return true;
            //return false;


            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> sDic = new Dictionary<char, int>();

            foreach (char sc in s)
            {
                if (sDic.ContainsKey(sc))
                {
                    sDic[sc]++;
                }
                else
                {
                    sDic.Add(sc, 1);
                }
            }

            foreach (char tc in t)
            {
                if (!sDic.ContainsKey(tc))
                    return false;

                if (sDic[tc] == 1)
                {
                    sDic.Remove(tc);
                }
                else
                {
                    sDic[tc]--;
                }
            }
            //if Count is 0 then TRUE, else FALSE
            return sDic.Count == 0;
        }
    }
}
