using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class SortInWaveForm
    {
        public int[] ConertWaveForm(int[] arr, int n)
        {
            bool flag = false;
            int temp = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (!flag && arr[i] < arr[i + 1])
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
                else if (flag && arr[i] > arr[i + 1])
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = arr[i];
                }
                flag = !flag;
            }
            return arr;
        }
    }
}
