using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class ProductOfArrayExceptSelfWithoutExtraSpace
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] output = new int[n];
            int product = 1;
            for (int i = 0; i < n; i++)
            {
                product *= nums[i];
                output[i] = product;
            }
            product = 1;
            for (int i = n - 1; i > 0; i--)
            {
                output[i] = output[i - 1] * product;
                product *= nums[i];
            }
            output[0] = product;
            return output;
        }
    }
}
