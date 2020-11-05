using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Multiplication
{
    class Program
    {
        
        static void CreateMatrix(int [,] Array, int row, int col)
        {

            Random rd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Array[i, j] = rd.Next(0, 50);
                }
            }
        }
        static void ShowMatrix(int [,] Array, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(Array[i, j]+"  ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int col1, row1, col2, row2;
            
            Console.WriteLine("Nhân 2 ma trận - 2 chiều");
            Console.WriteLine("Nhập ma trận thứ nhất");
            Console.Write("Số hàng: ");
            row1 = int.Parse(Console.ReadLine());
            Console.Write("Số cột: ");
            col1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập ma trận thứ hai");
            Console.Write("Số hàng: ");
            row2 = int.Parse(Console.ReadLine());
            Console.Write("Số cột: ");
            col2 = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");
            int[,] Array1 = new int[col1, row1];
            int[,] Array2 = new int[col2, row2];
            Console.WriteLine("Ma trận thứ nhất");
            ShowMatrix(Array1, row1, col1);
            Console.WriteLine("Ma trận thứ hai");
            ShowMatrix(Array2, row2, col2);
            Console.ReadKey();
        }
    }
}