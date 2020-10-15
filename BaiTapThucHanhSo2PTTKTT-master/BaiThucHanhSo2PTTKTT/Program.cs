
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanhSo2PTTKTT
{
    class Program
    {
        // BaiTapMau1

        static int GiaiThua(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * GiaiThua(x - 1);
            }
        }
        static double SoMu(int x, int soMu)
        {
            double results = 1;
            if (soMu == 0)
                results = 1;
            else
            {
                results = Math.Pow(x, soMu);
            }
            return results;
        }

        static double KhoiTaoBai1(int x, int n)
        {
            double results = 0;

            for (int i = 0; i <= n; i++)
            {
                results += SoMu(x, i) / GiaiThua(i);
            }
            return results;
        }

        // Bai 2
        // Hàm chuẩn hóa số để định dạng 2 chuỗi có cùng độ dài 
        // Số nào độ dài ngắn hơn thì sẽ thêm kí tự 0 vào bên trái
        static void chuanHoaSo(ref string so1, ref string so2)
        {
            StringBuilder s1 = new StringBuilder(so1);
            StringBuilder s2 = new StringBuilder(so2);
            if (s1.Length > s2.Length)
                while (s2.Length < s1.Length)
                    s2.Insert(0, "0");
            else
                if (s2.Length > s1.Length)
                    while (s1.Length < s2.Length)
                        s1.Insert(0, "0");
            so1 = s1.ToString();
            so2 = s2.ToString();
        }
        // Tính tổng 2 số 
        static string tinhTong(string so1, string so2)
        {
            string s;
            int t, a, b, nho = 0;
            /*
             * 
             */
            int n;
            chuanHoaSo(ref so1, ref so2);
            StringBuilder kq = new StringBuilder("");
            n = so1.Length - 1;
            while (n >= 0)
            {
                a = so1[n] - 48;
                b = so2[n] - 48;
                t = a + b + nho;
                s = t.ToString();
                if (s.Length == 1) s = "0" + s;
                nho = s[0] - 48;
                kq.Insert(0, s[1]);
                n = n - 1;
            }
            if (nho == 1) kq.Insert(0, "1");
            return kq.ToString();
            
        }
        // Bài 3
        static void NhapMang1Chieu(int [] array)
        {
            Random rd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(-99, 99);
            }
        }
        static int TinhTongLonNhatCuaMotDay(int [] array)
        {
            int resutl = 0;
            int resutlCompare = 0;
            for (int i = 0; i < array.Length-3; i++)
            {
                resutl = array[i] + array[i+1];
                resutlCompare = array[i] + array[i + 1] + array[i + 2];
                if (resutl < resutlCompare)
                {

                }
            }
            return resutl;
        }
        static void maxSubArraySum(int[] a, int size)
        {
            //  int[] a = { -2, -3, -4, -1, 100, 10, 20, -20, 34, -42, -112, -5, -3 };
            int max_so_far = int.MinValue, // gán cho giá trị nhỏ nhất của kiểu dữ liệu int
            // gái trị max_ending là để so sánh
            max_ending_here = 0, start = 0,
            end = 0, s = 0;

            for (int i = 0; i < size; i++)
            {
                // Gán giá trị biến so sánh
                max_ending_here += a[i];
                // Nếu tổng lớn nhất lớn hơn giá trị max thì gán max thành tổng lớn nhất
                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;

                    start = s;
                    end = i;
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;

                    s = i + 1;
                }
            }
            Console.WriteLine("Maximum contiguous " +
                             "sum is " + max_so_far);
            Console.WriteLine("Starting index " +
                                          start);
            Console.WriteLine("Ending index " +
                                          end);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Bài số 1:");
            //Console.Write("Nhập giá trị của x: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Nhập giá trị của n: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(KhoiTaoBai1(x, n));


            //string so1, so2;
            //StringBuilder x = new StringBuilder("");
            //StringBuilder y = new StringBuilder("");
            //StringBuilder s = new StringBuilder("");
            //Console.WriteLine("\t\t BAN HAY NHAP VAO HAI SO NGUYEN");
            //Console.Write(" "); so1 = Console.ReadLine();
            //Console.WriteLine("+");

            //Console.Write(" "); so2 = Console.ReadLine();
            //x.Append('-', so1.Length > so2.Length ? so1.Length : so2.Length);
            //y.Append(' ', Math.Abs(so1.Length - so2.Length));
            //s.AppendFormat("\t\t{0}\n\n", "BAN HAY NHAP VAO HAI SO NGUYEN");
            //if (so1.Length < so2.Length)
            //    s.AppendFormat(" {0}{1}\n", y.ToString(), so1);
            //else
            //    s.AppendFormat(" {0}\n", so1);
            //s.AppendFormat("{0}\n", "+");
            //if (so2.Length < so1.Length)
            //    s.AppendFormat(" {0}{1}\n", y.ToString(), so2);
            //else
            //    s.AppendFormat(" {0}\n", so2);
            //s.AppendFormat(" {0}\n", x.ToString());
            //s.AppendFormat(" {0}", tinhTong(so1, so2));
            //Console.Clear();
            //Console.WriteLine(s);
            //Console.ReadKey();

            int[] a = { -2, -3, -4, -1, 100, 10, 20, -20, 34, -42, -112, -5, -3 };
            int n = a.Length;
            maxSubArraySum(a, n);
            Console.ReadKey();
        }
    }
}
