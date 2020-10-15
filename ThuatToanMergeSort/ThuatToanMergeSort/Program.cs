using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToanMergeSort
{
    class Program
    {
        static void RamdomMember(ref int[] Array, int n)
        {
            Random rd = new Random();
            for(int i = 0; i < n; i++)
            {
                Array[i] = rd.Next(1, 1000);
            }
        }
        static void Show(int [] Array)
        {
            foreach (int item in Array)
            {
                Console.Write(item+"\t");
            }
            Console.WriteLine();
        }
        static void SelectionSort(int [] Array)
        {
            for (int i = 0; i < Array.Length-1; i++)
            {
                int min_index = i;
                for (int j = i+1 ; j < Array.Length; j++)
                {
                    if (Array[j] < Array[min_index])
                    {
                        min_index = j;
                    }
                }
                int change = Array[min_index];
                Array[min_index] = Array[i];
                Array[i] = change;
            }
        }
        static void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
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
        static void Main(string[] args)
        {
            /*
             * Input: Tham số truyền vào là mảng 1 chiều có n phần tử ngẫn nhiên,
             * Yêu cầu: Mảng trả về sắp xếp theo chiều tăng và thời gian
             * Bài 1: Sử dụng selection sort
             * Bài 2: Sử dụng Merge Sort
             */
            Console.OutputEncoding = Encoding.UTF8;
            Stopwatch st = new Stopwatch();
            Console.Write("Số trường hợp so sánh");
            int loops = int.Parse(Console.ReadLine());
            // Số trường hợp
            int n;
            // Mảng để sắp xếp
            int[] array;
            // Mảng sao chép
            int[] arrayCopy;
            // Mảng lưu số giá trị so sánh
            int[] numbers = new int[loops];
            // Thời gian sắp xếp của Selection
            double[] timeSelectionSort = new double [loops];
            // Thời gian của merge
            double[] timemergeSort = new double[loops];
            for (int i = 0; i < loops; i++)
            {
                Console.Write("Nhập số phần tử của mảng: ");
                n = int.Parse(Console.ReadLine());
                array = new int[n];
                arrayCopy = new int[n];
                numbers[i] = n;
                RamdomMember(ref array, n);
                Array.Copy(array, arrayCopy, n);
                st.Reset();
                st.Start();
                SelectionSort(array);
                st.Stop();
                timeSelectionSort[i]=st.Elapsed.TotalSeconds;

                st.Reset();
                st.Start();
                MergeSort(arrayCopy, 0, n - 1); ;
                st.Stop();
                timemergeSort[i]=st.Elapsed.TotalSeconds;
            }
            string number = "";
            string timeSelect ="";
            string timemerge="";
            foreach (int item in numbers)
            {
                number += item.ToString() + "\t\t";
            }
            foreach (double item in timeSelectionSort)
            {
                timeSelect += item.ToString() + "\t";
            }
            foreach (double item in timemergeSort)
            {
                timemerge += item.ToString() + "\t";
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(String.Format("Số phần tử so sánh       : {0}",number));
            Console.WriteLine(String.Format("Thời gian chạy Selection : {0}",timeSelect));
            Console.WriteLine(String.Format("Thời gian chạy Merge     : {0}",timemerge));
            Console.ReadKey();


        }
    }
}
