using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class EquilibriumIndex
    {
        public int PivotIndex(int[] nums)
        {
            int n = nums.Count();
            int totalSum = 0;
            int runningSum = 0;
            for (int i = 0; i < n; i++)
            {
                totalSum += nums[i];
            }
            for (int i = 0; i < n; i++)
            {
                int diff = totalSum - runningSum - nums[i];
                if (diff == runningSum)
                {
                    return i;
                }
                runningSum += nums[i];
            }
            return -1;
        }
    }
}
