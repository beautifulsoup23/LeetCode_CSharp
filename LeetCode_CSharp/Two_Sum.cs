using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    public class Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var res = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        res = new int[] { j, i };
                    } 
                }
            }

            return res;
        }
    }
}
