using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAlogorithm
{
    class Program
    {
        static int Partition(int [] A,int left, int right)
        {
            // Chọn x là pivot để so sánh
            int X = A[left];
            // i là chỉ số đầu tiên của mảng có phần tử nhỏ hơn chốt
            int i = left + 1;
            // j là chỉ số cuối cùng của mảng có phần tử lớn hơn chốt
            int j = right;
            // Biến t là để hoán đổi giá trị khi so sánh 2 phần tử với nhau
            int t;
            do
            {
                // Nếu i nhỏ hơn h và giá trị của phần tử có chỉ số i của mảng nhỏ hơn mà bé hơn chốt thì 
                while (i <= j && A[i] <= X)
                {
                    i++;
                }
                while (i <= j && A[j] > X)
                {
                    j--;
                }
                if (i < j)
                {
                    t = A[i];
                    A[i] = A[j];
                    A[j] = t;
                    i++;
                    j--;
                }
            } while (i <= j);
            t = A[left];
            A[left] = A[j];
            A[j] = t;
            
            return j;
        }
        static void QuickSort(int [] A,int left, int right)
        {
            int k;
            if (left < right)
            {
                k = Partition(A, left, right);
                QuickSort(A, left, k - 1);
                QuickSort(A, k + 1, right);
            }
        }
        static void RamdomMember(int[] Array, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                Array[i] = rd.Next(1, 1000);
            }
        }
        static void Show(int[] Array)
        {
            foreach (int item in Array)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        static bool BinarySearch(int [] array,int x,int left,int right)
        {
            if (left > right)
            {
                return false;
            }
            else
            {
                int tmp = (left + right) / 2;
                if (x == array[tmp])
                {
                    return true;
                }
                else
                {
                    if (x > array[tmp]) 
                        return BinarySearch(array, x, tmp +1, right);
                    else
                        return BinarySearch(array, x, left, tmp-1);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] array;
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            array = new int[n];
            RamdomMember(array, n);
            Show(array);
            QuickSort(array, 0, n-1);
            Show(array);
            Console.Write("Nhập phần tử của mảng: ");
            int find = int.Parse(Console.ReadLine());
            if (BinarySearch(array,find,0,n-1))
            {
                Console.WriteLine("Có phần tử");
            }
            else
            {
                Console.WriteLine("Không có phần tử");
            }
            Console.ReadKey();
        }
    }
}
