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
        }
    }
}
