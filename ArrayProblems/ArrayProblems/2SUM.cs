using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class _2SUM
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int n = nums.Count();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, dict[target - nums[i]] };
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
