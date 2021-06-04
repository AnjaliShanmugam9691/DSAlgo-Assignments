using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class MedianOfTwoSortedArray
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int X = nums1.Length;
            int Y = nums2.Length;
            double result = 0;
            if (X > Y)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }
            int l = 0;
            int h = X - 1;
            while (l <= h)
            {
                int partitionX = (l + h) / 2;
                int partitionY = (X + Y + 1) / 2 - partitionX;
                int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
                int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
                int minRightX = (partitionX == X) ? int.MaxValue : nums1[partitionX];
                int minRightY = (partitionY == Y) ? int.MaxValue : nums2[partitionY];
                if (maxLeftX <= minRightY && maxLeftY <= minRightX)
                {
                    //if the length of the total array is odd
                    if ((X + Y) % 2 != 0)
                    {
                        result = Math.Max(maxLeftX, maxLeftY);
                    }
                    else
                    {
                        result = (Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2;
                    }
                }
                else if (maxLeftX > minRightY)
                {
                    h = partitionX - 1;
                }
                else
                {
                    l = partitionX + 1;
                }
            }
            return result;
        }
    }
}
