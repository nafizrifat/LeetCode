using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0300
{
    public class _217_ContainsDuplicate
    {

        public bool ContainsDuplicate(int[] nums)
        {
            //Using Dictionaly
            //Dictionary<int,int>  dic = new Dictionary<int,int>();

            //for (int i = 0; i < nums.Length; i++) {

            //    if (dic.ContainsKey(nums[i]))
            //    {
            //        return true;
            //    }
            //    //if (!dic.ContainsKey(nums[i]))
            //    //{
            //        dic.Add(nums[i], i);
            //    //}
            //}
            //return false;

            //Using Hashset
            HashSet<int> seen = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (seen.Contains(nums[i]))
                {
                    return true;
                }

                seen.Add(nums[i]);
            }

            return false;


            //Shorter Version Using Add()
            //HashSet<int> seen = new HashSet<int>();

            //foreach (int num in nums)
            //{
            //    if (!seen.Add(num))
            //    {
            //        return true;
            //    }
            //}

            //return false;
        }
    }

}
