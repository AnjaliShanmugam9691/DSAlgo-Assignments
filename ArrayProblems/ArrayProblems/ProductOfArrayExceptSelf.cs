using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class ProductOfArrayExceptSelf
    {
        public int[] ProductArrayExceptSelf(int[] arr)
        {
            int n = arr.Length;
            //we need to find the left product and the right product of each ith element
            int[] leftArray = new int[n];
            int[] rightArray = new int[n];
            int[] outputArray = new int[n];
            int product = 1;
            //find the leftArray and start with the second element since there is no left element for the first one
            //the boundary case for the first element we can conclude the number itself the left product
            for(int i=0; i<n; i++)
            {
                if(i == 0)
                {
                    product *= arr[i];
                    leftArray[i] = product;
                }
                else
                {
                    product *= arr[i];
                    leftArray[i] = product;
                }               
            }
            //find the right Array and start with the last element.  
            // here there is no right side element for the last element. Hence the number itself will come
            product = 1;
            for (int i = n-1; i>=0; i--)
            {
                if(i == n-1)
                {
                    product *= arr[n - 1];
                    rightArray[i] = product;
                }
                else
                {
                    product *= arr[i];
                    rightArray[i] = product;
                }
            }

            //now we need to take the leftarray elements and the rightarray elements based on the ith element
            //here we have the boundary cases for 0th element and the n-1th element
            for(int i =0; i<n; i++)
            {
                if (i == 0)
                {
                    outputArray[i] = rightArray[1];
                }
                else if (i == (n-1))
                {
                    outputArray[n - 1] = leftArray[n - 2];
                }
                else
                {
                    outputArray[i] = leftArray[i - 1] * rightArray[i + 1];
                }
            }
            return outputArray;
        }
    }
}
