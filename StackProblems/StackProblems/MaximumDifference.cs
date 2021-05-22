using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class MaximumDifference
    {
        public int MaximumDiffBetweenLeftRightSmallest(int[] arr)
        {
            int result = 0;
            int n = arr.Count();
            int[] leftArray = new int[n];
            int[] rightArray = new int[n];
            LeftSmallestElement(arr, n, leftArray);
            Reverse(arr);
            LeftSmallestElement(arr, n, rightArray);
            for(int i = 0; i<n; i++)
            {
                result = Math.Max(result, Math.Abs(leftArray[i] - rightArray[n - 1 - i]));
            }
            return result;
        }

        //finding the nearest smallest elements
        public void LeftSmallestElement(int[] a, int n, int[] SE)
        {
            Stack<int> st = new Stack<int>();
            for(int i=0; i<n; i++)
            {
                while(st.Count() != 0 && st.Peek() >= a[i])
                {
                    st.Pop();
                }
                if(st.Count() != 0)
                {
                    SE[i] = st.Peek();
                }
                else
                {
                    SE[i] = 0;
                }
                st.Push(a[i]);
            }
        }

        public void Reverse(int[] a)
        {
            int i = 0;
            int j = a.Length - 1;
            int temp = 0;
            while(i<j)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                i++;
                j--;
            }
        }
    }
}
