//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/build-an-array-with-stack-operations/
//-----------------------------------------------------------------------------
namespace LeetCode._1201_1500
{
    public class _1441_BuildanArrayWithStackOperations
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            //RS
            //List<string> result = new List<string>();
            //Stack<int> s = new Stack<int>();
            //int targetV = 0;
            //for (int i = 1; i <= n; i++) { 

            //    s.Push(i);
            //    result.Add("Push");

            //    if (s.Peek() != target[targetV])
            //    {
            //        s.Pop();
            //        result.Add("Pop");
            //    }
            //    else
            //    {
            //        targetV++;
            //    }

            //        bool isEqual = s.SequenceEqual(target.Reverse());

            //    if(isEqual)
            //        return result;
            //}
            //return result;

            //RS Optimized
            //List<string> result = new List<string>();
            //Stack<int> stack = new Stack<int>();

            //int targetV = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    stack.Push(i);
            //    result.Add("Push");

            //    if (stack.Peek() != target[targetV])
            //    {
            //        stack.Pop();
            //        result.Add("Pop");
            //    }
            //    else
            //    {
            //        targetV++;
            //    }

            //    if (targetV == target.Length)
            //        return result;
            //}

            //return result;

            //Better
            List<string> result = new List<string>();

            int targetV = 0;

            for (int i = 1; i <= n; i++)
            {
                result.Add("Push");

                if (i != target[targetV])
                {
                    result.Add("Pop");
                }
                else
                {
                    targetV++;
                }

                if (targetV == target.Length)
                    break;
            }

            return result;

        }
    }
}
