using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class Sort0s1s2s
    {
        public int[] SortList(int[] nums)
        {
            int low = 0;
            int mid = 0;
            int high = nums.Count() - 1;
            int temp = 0;
            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    temp = nums[mid];
                    nums[mid] = nums[low];
                    nums[low] = temp;
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    temp = nums[mid];
                    nums[mid] = nums[high];
                    nums[high] = temp;
                    high--;
                }
            }
            return nums;
        }
    }
}
