using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        #region MethodArray
        static void CreateRandomArray(int[] array, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rd.Next(-99, 1000);
            }
        }
        static void ShowArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        #endregion
        static bool CheckSNT(int a)
        {
            if (a < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2 ; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static bool CheckSoDoiXung(int a)
        {
            bool check = true;
            int soTraVe = 0, thuong = 0,soBanDau = a ;
            while (soBanDau != 0)
            {
                soTraVe = soTraVe * 10;
                thuong = soBanDau % 10;
                soBanDau = soBanDau / 10;
                soTraVe += thuong;
            }
            if (soTraVe != a)
                check = false;
            return check;
        }
        static double TinhGiaiThua(int n)
        {
            int resutl = 1;
            if (n < 1)
            {
                return resutl;
            }
            for (int i = 1; i <= n; i++)
            {
                resutl *= i;
            }
            return resutl;
        }
        static double TinhBai3Cach1(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return TinhBai3Cach1(x, n - 1) + (Math.Pow(x, n) / TinhGiaiThua(n));
            }
        }
        static double TinhBai3Cach2(int x,int n)
        {
            double resutl = 0;
            for (int i = 0; i <= n; i++)
            {
                resutl += Math.Pow(x, i) / TinhGiaiThua(i);
            }
            return resutl;
        }
        static void MinMaxInArray(int [] A, int left, int right,ref int min ,ref int max)
        {
            if (left == right)
            {
                min = max = A[left];
            }
            else if(left == right - 1)
            {
                if (A[left] < A[right])
                {
                    max = A[right];
                    min = A[left];
                }
                else
                {
                    max = A[left];
                    min = A[right];
                }
            }
            else
            {
                int mid = (left + right) / 2;
                int min1 = A[mid] , max1 = A[mid];
                MinMaxInArray(A, left, mid,ref min,ref max);
                MinMaxInArray(A, mid + 1, right,ref min1,ref max1);
                if (min1 < min)
                {
                    min = min1;
                }
                if (max1 > max)
                {
                    max = max1;
                }
            }
        }
        static bool FindBinary(int [] A,int x, int left, int right)
        {
            bool check = true;
            if (left > right)
            {
                check = false;
            }
            else
            {
                int mid = (right + left) / 2;
                if (x == A[mid])
                {

                }
                else
                {
                    if (x < A[mid])
                        FindBinary(A, x, left, mid);
                    else
                        FindBinary(A, x, mid + 1, right);
                }
            }
            return check;
        }

        #region QuickSort
        static int Partion(int[] A, int left, int right)
        {
            int pivot = A[left];
            int i = left + 1;
            int j = right;
            int tmp;
            do
            {
                while (i <= j && A[i] <= pivot)
                {
                    i++;
                }
                while (i <= j && A[j] > pivot)
                {
                    j--;
                }
                if (i < j)
                {
                    tmp = A[j];
                    A[j] = A[i];
                    A[i] = tmp;
                    i++;
                    j--;
                }
            } while (i < j);
            tmp = A[left];
            A[left] = A[j];
            A[j] = tmp;
            return j;
        }
        static void QuickSort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int i = Partion(A, left, right);
                QuickSort(A, left, i);
                QuickSort(A, i + 1, right);
            }
        }
        #endregion

        #region MergeSort
        static void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;

            //k là chạy chỉ số của mảng ban đầu
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }
        #endregion
        

        static void  Merge2(int [] A,int left,int mid,int right)
        {

        }
        static void MergeSort2(int [] A,int left,int mid,int right)
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine(TinhBai3Cach1(2,4));
            Console.WriteLine(TinhBai3Cach2(2,4));
            int[] A = new int[8];
            CreateRandomArray(A, 8);
            ShowArray(A);
            int min = 0, max = 0;
            MinMaxInArray(A, 0, 6, ref min, ref max);
            Console.WriteLine(min +"\t"+max);
            Console.WriteLine("So nguyen to");
            foreach (int item in A)
            {
                if (CheckSNT(item))
                    Console.Write(item+"\t");
            }
            Console.WriteLine();
            Console.WriteLine("So doi xung");
            foreach (int item in A)
            {
                if (CheckSoDoiXung(item))
                    Console.Write(item + "\t");
            }
            Console.WriteLine();
            MergeSort(A, 0, 9);
            QuickSort(A, 0, 9);
            ShowArray(A); 
            Console.ReadKey();
        }
    }
}
