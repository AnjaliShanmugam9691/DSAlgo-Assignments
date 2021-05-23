using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class SpiralOrderMatrix
    {
        public List<int> PrintSpiralOrerMatrix(int[,] A)
        {
            List<int> result = new List<int>();
            int i, j = 0;
            int dir = 0;       // this will be incremented // 0 - right, 1 - down, 2 - left, 3 - up
            int top = 0;       // typically the first row
            int bottom = A.GetLength(0) - 1;   //the last row
            int left = 0;       // first column
            int right = A.GetLength(0) - 1;    // last column
            // we need to iterate till we print all the numbers in the matrix
            while (top <= bottom && left <= right)             
            {
                if(dir == 0)
                {
                    for(i=left; i<=right; i++)     //we need to iterate from left to right
                    {
                        result.Add(A[top,i]);
                    }
                    top++;                      //the first row completed now. So increment the top row to the next row
                    dir = 1;
                }
                else if (dir == 1)
                {
                    for (j = top; j <= bottom; j++)     //we need to iterate from top to bottom
                    {
                        result.Add(A[j,right]);
                    }
                    right--;                      //the last column completed now. So decrement the right boundary
                    dir = 2;
                }
                else if (dir == 2)
                {
                    for (i = right; i >= left; i--)     //we need to iterate from right to left
                    {
                        result.Add(A[bottom,i]);
                    }
                    bottom--;                      //the last row completed now. So decrement the bottom boundary
                    dir = 3;
                }
                else if (dir == 3)
                {
                    for (j = bottom; j >= top; j--)     //we need to iterate from bottom to top
                    {
                        result.Add(A[j,left]);
                    }
                    left++;                      //initially the first column completed now. So increment the left boundary
                    dir = 0;
                }
            }
            return result;
        }
    }
}
