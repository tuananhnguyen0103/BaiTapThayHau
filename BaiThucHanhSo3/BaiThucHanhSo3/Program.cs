using System;

namespace BaiThucHanhSo3
{
    class Program
    {
        // Bài 4 trang 69
        

        // Mẫu số
        static double MauSo(int n)
        {
            double S = 0;
            for (int i = 1; i <= n; i++)
            {
                S += 1 / i;
            }
            return S;
        }
        static double Bai4Trang69(int n, int x)
        {
            double results = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    results -= Math.Pow(x, i)/MauSo(i);
                }
            }
            return results;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
