using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort2
{
    class Program
    {
        static void Show(int [] Array)
        {
            foreach (int item in Array)
            {
                Console.Write(item+"\t");
            }
            Console.WriteLine();
        }
        static void RandomValue(int [] Array , int Lenght)
        {
            Random rd = new Random();
            for (int i = 0; i < Lenght-1; i++)
            {
                Array[i] = rd.Next(-99, 99);
            }
        }
        static void MergeSort(int[] input,int left ,int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(input, left, mid);
                MergeSort(input, mid + 1, right);
                Merge(input, left, mid, right);
            }
        } 
        static void Merge(int[] input, int left,int mid, int right)
        {
            int[] leftArray = new int[mid - left + 1];
            int[] rightArray = new int[right - mid];

            Array.Copy(input, left, leftArray, 0, mid - left + 1);
            Array.Copy(input, mid + 1, rightArray, 0, right - mid);

            int i = 0, j = 0;

            for (int k = left; k < right+1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if(j == rightArray.Length)
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
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: " );
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];
            RandomValue(array,elements);
            Show(array);
            MergeSort(array, 0, elements - 1);
            Show(array);

            Console.ReadKey();
        }
    }
}
