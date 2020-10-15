using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegerSort
{
    class Program
    {
        static void Meger(int[] A, int left,int mid, int right)
        {
            int[] leftArray = new int[mid - left + 1];
            int[] rightArray = new int[right - mid];

            Array.Copy(A, left, leftArray, 0, mid - left + 1);
            Array.Copy(A, mid + 1, rightArray, 0, right - mid);
            int i = 0, j = 0;
            for (int k = left; k <= right; k++)
            {
                if(i == leftArray.Length)
                {
                    A[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    A[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    A[k] = leftArray[i];
                    i++;
                }
                else
                {
                    A[k] = leftArray[j];
                    j++;
                }
            }
        }
        static void MegerSort(int [] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MegerSort(A, left, mid);
                MegerSort(A, mid + 1, right);

                Meger(A, left, mid, right);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
