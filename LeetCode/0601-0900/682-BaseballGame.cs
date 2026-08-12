//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/baseball-game/description/
//-----------------------------------------------------------------------------


using System.Net.Http.Headers;

namespace LeetCode._0601_0900
{
    public class _682_BaseballGame
    {
        public int CalPoints(string[] operations)
        {
            //Stack<int> stack = new Stack<int>();

            //foreach (string i in operations)
            //{
            //    if (i == "+")
            //    {
            //        int sum = stack.Take(2).Sum();
            //        stack.Push(sum);
            //    }
            //    else if (i == "D")
            //    {
            //        int dbl = 2 * stack.Peek();
            //        stack.Push(dbl);
            //    }
            //    else if (i == "C")
            //    {
            //        stack.Pop();
            //    }
            //    else
            //        stack.Push(Convert.ToInt32(i));
            //}
            //return stack.Sum();

            Stack<int> stack = new Stack<int>();

            foreach (string operation in operations) {

                if (operation == "+")
                {
                    int top = stack.Pop();
                    int secondLast = stack.Peek();
                    stack.Push(top);
                    stack.Push(secondLast + top);
                }

                else if (operation == "D")
                {
                    stack.Push(stack.Peek() * 2);
                }

                else if (operation == "C") {
                    stack.Pop();
                }
                else
                    stack.Push(int.Parse(operation));
            }

            return stack.Sum();

        }
    }
}
