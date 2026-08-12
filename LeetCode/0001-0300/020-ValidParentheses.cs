//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/valid-parentheses/description/
//-----------------------------------------------------------------------------

namespace LeetCode._0001_0300
{
    public class _020_ValidParentheses
    {
        public bool IsValid(string s)
        {
            //    Stack<char> sP = new Stack<char>();

            //    foreach (char c in s)
            //    {

            //        //add to stack
            //        if (c == '(' || c == '[' || c == '{')
            //        {
            //            sP.Push(c);
            //        }

            //        else if (sP.Count()>0 &&
            //            (c == ')' && sP.Peek() == '(') ||
            //            (c == ']' && sP.Peek() == '[') ||
            //            (c == '}' && sP.Peek() == '{')
            //                )
            //        {
            //            sP.Pop();
            //        }
            //        else
            //            return false;

            //    }
            //    if(sP.Count==0)
            //        return true;
            //    return false;
            //}

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {

                //Opeaning breackets
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char opeaning = stack.Peek();

                    if (
                        (c == ')' && opeaning == '(') ||
                        (c == ']' && opeaning == '[') ||
                        (c == '}' && opeaning == '{')
                        )
                    {
                        stack.Pop();
                    }
                    else
                        return false;
                }

            }
            return stack.Count == 0;
        }
    }

}
