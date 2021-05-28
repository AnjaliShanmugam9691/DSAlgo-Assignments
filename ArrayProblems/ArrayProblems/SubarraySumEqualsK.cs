using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class SubarraySumEqualsK
    {
        public int SubArraySumEqualsToKFn(int[] nums, int k)
        {
            int n = nums.Count();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 1);
            int sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                sum += nums[i];

                if (dict.ContainsKey(sum - k))
                {
                    count += dict[sum - k];
                }

                if (dict.ContainsKey(sum))
                {
                    dict[sum]++;
                }
                else
                {
                    dict.Add(sum, 1);
                }

            }
            return count;
        }
    }
}
