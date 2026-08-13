//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/backspace-string-compare/description/
//-----------------------------------------------------------------------------
using System.Linq;

namespace LeetCode._0601_0900
{
    public class _844_BackspaceStringCompare
    {
        public bool BackspaceCompare(string s, string t)
        {
            Stack<char> ss = new Stack<char>();
            Stack<char> st = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '#')
                {
                    if (ss.Count > 0)
                        ss.Pop();
                }
                else
                    ss.Push(c);
            }

            foreach (char c in t)
            {
                if (c == '#')
                {
                    if (st.Count > 0)
                        st.Pop();
                }
                else
                    st.Push(c);
            }

            //bool areEqual = ss.SequenceEqual(st);
            //return areEqual;
            return ss.SequenceEqual(st);
        }
    }
}
