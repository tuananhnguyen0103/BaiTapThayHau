using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchMinMax
{
    class Program
    {
        static void FindMinMax(int[]A,int i,int j,ref int Max,ref int Min)
        {
            if (i == j)
            {
                Max = Min = A[j];
            }
            else if (i == j - j)
            {
                if (A[i] < A[j])
                {
                    Max = A[j];
                    Min = A[i];
                }
                else
                {
                    Max = A[i];
                    Min = A[j];
                }
            }
            else
            {
                int mid = (i + j) / 2;
                int Max1, Min1;
                Max1 = Min1 = A[mid + 1];
                FindMinMax(A, i, mid, ref Max, ref Min);
                FindMinMax(A, mid + 1, j, ref Max1, ref Min1);
                if (Max < Max1)
                {
                    Max = Max1;
                }
                if(Min > Min1)
                {
                    Min = Min1;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1000, 11, 445, 1, 330, 3000 };
            int min=0,max = 0;
            FindMinMax(arr, 0, arr.Length - 1, ref min, ref max);
            Console.WriteLine("Min: "+min+"\t"+"Max:"+"\t"+max);

            Console.ReadKey();
        }
    }
}
