//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/description/
//-----------------------------------------------------------------------------
namespace LeetCode._0901_1200
{
    public class _1047_RemoveAllAdjacentDuplicatesInString
    {
        public string RemoveDuplicates(string s)
        {
            //Stack<char> stack = new Stack<char>();

            //foreach(char c in s)
            //{
            //    if (stack.Count == 0)
            //        stack.Push(c);
            //    else 
            //    {
            //        char previous = stack.Peek();

            //        if (c == previous)
            //            stack.Pop();
            //        else
            //            stack.Push(c);
            //    }
            //}
            //string result = string.Join("", stack.Reverse());
            //return result;

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count > 0 && stack.Peek() == c)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            return new string(stack.Reverse().ToArray());
        }
    }
}
