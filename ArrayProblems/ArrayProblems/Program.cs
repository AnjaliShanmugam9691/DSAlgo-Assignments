using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spiral Order Matix - Print
            int[,] som = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            SpiralOrderMatrix s = new SpiralOrderMatrix();
            var somRes = s.PrintSpiralOrerMatrix(som);
            Console.WriteLine(somRes);

            //Sort 0s 1s 2s 
            int[] sortIP = new int[] {2, 0, 2, 1, 1, 0};
            Sort0s1s2s sort = new Sort0s1s2s();
            var sortOP = sort.SortList(sortIP);
            Console.WriteLine(sortOP);

            //Product Of Array Except Self
            int[] proarr = new int[] { 1, 2, 3, 4 };
            ProductOfArrayExceptSelf p = new ProductOfArrayExceptSelf();
            var proOut = p.ProductArrayExceptSelf(proarr);
            Console.WriteLine(proOut);

            //Product Of Array Except Self - Without Extra Space
            int[] proarr1 = new int[] { 1, 2, 3, 4 };
            ProductOfArrayExceptSelfWithoutExtraSpace p1 = new ProductOfArrayExceptSelfWithoutExtraSpace();
            var proOut1 = p1.ProductExceptSelf(proarr1);
            Console.WriteLine(proOut1);

            //Task Scheduler
            char[] tsArr = new char[] { 'A', 'A', 'A', 'B', 'B', 'B' };
            TaskScheduler ts = new TaskScheduler();
            var tsOutput = ts.TaskSchedulerFn(tsArr, 2);
            Console.WriteLine(tsOutput);

            //2 SUM
            int[] twoSumArr = new int[] { 2,7,11,15 };
            _2SUM twoSum = new _2SUM();
            var twoSumOP = twoSum.TwoSum(twoSumArr, 9);
            Console.WriteLine(twoSumOP);

            //Subarray Sum Equals to K
            int[] subArray = new int[] { 1, 2, 3 };
            SubarraySumEqualsK sub = new SubarraySumEqualsK();
            var sumOP = sub.SubArraySumEqualsToKFn(subArray, 3);
            Console.WriteLine(sumOP);

            //Search in Rotated Sorted Array
            int[] searchIp = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            SearchInRotatedSortedArray search = new SearchInRotatedSortedArray();
            var searchOp = search.Search(searchIp, 0);
            Console.WriteLine(searchOp);

            //Sort an array in Wave Form
            int[] waveIP = new int[] { 1, 2, 3, 4, 5 };               
            int n = waveIP.Length;
            SortInWaveForm wave = new SortInWaveForm();
            var waveOP = wave.ConertWaveForm(waveIP, n);
            Console.WriteLine(waveOP);

            //Find Pivot Index - Equlibrium Index
            int[] pivotIP = new int[] { 1, 7, 6, 5, 6 };
            EquilibriumIndex idx = new EquilibriumIndex();
            int pivotOP = idx.PivotIndex(pivotIP);
            Console.WriteLine(pivotOP);

            //Find Median of Two Sorted Array
            int[] medianIP1 = new int[] { 4, 7, 8, 9, 12, 15 };
            int[] medianIP2 = new int[] { 18, 20, 24, 27 };
            MedianOfTwoSortedArray med = new MedianOfTwoSortedArray();
            double medianOP = med.FindMedianSortedArrays(medianIP1, medianIP2);
            Console.WriteLine(medianOP);
        }
    }
}
