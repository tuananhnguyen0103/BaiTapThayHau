using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
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
        static bool BinarySearch(int[] array, int x, int left, int right)
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
                        return BinarySearch(array, x, tmp + 1, right);
                    else
                        return BinarySearch(array, x, left, tmp - 1);
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
            Console.Write("Nhập phần tử của mảng: ");
            int find = int.Parse(Console.ReadLine());
            if (BinarySearch(array, find, 0, n - 1))
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
