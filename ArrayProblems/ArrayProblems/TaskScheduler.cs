using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class TaskScheduler
    {
        public int TaskSchedulerFn(char[] A, int n)
        {
            int[] freqArr = new int[26];
            foreach (var c in A)
            {
                freqArr[c - 'A'] = freqArr[c - 'A'] + 1;
            }
            Array.Sort(freqArr);
            int max = freqArr[freqArr.Length - 1] - 1;
            int idleCount = max * n;
            for (int i = freqArr.Length - 2; i >= 0; i--)
            {
                idleCount = idleCount - Math.Min(max, freqArr[i]);
            }
            return idleCount > 0 ? idleCount + A.Count() : A.Count();
        }
    }
}
