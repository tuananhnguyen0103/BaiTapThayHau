using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThayHau
{
    class Program
    {
        static int FindMin1(int [] A1)
        {
            int resultMin1 = A1[0];
            for (int i = 1; i < A1.Length; i++)
                if (resultMin1 > A1[i])
                    resultMin1 = A1[i];
            return resultMin1;
        }
        static int FindMin2(int[,] A2,int row, int col)
        {
            int resultMin2 = A2[0,0];
            for (int i = 0; i < row; i++)
                for(int j = 0;j< col; j++)
                {
                    if (resultMin2 > A2[row, col])
                    {
                        resultMin2 = A2[row, col];
                    }
                }
            return resultMin2;
        }
        static int FindMax1(int [] A1)
        {
            int resultMax1 = A1[0];
            for (int i = 1; i < A1.Length; i++)
                if (resultMax1 < A1[i])
                    resultMax1 = A1[i];
            return resultMax1;
        }
        static int FindMax2(int[,] A2,int row,int col)
        {
            int resultMax2 = A2[0, 0];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    if (resultMax2 < A2[row, col])
                    {
                        resultMax2 = A2[row, col];
                    }
                }
            return resultMax2;
        }
        static void Bai1()
        {
            string check;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Mảng 1 chiều");
                Console.WriteLine("2. Mảng 2 chiều");
                Console.WriteLine("Mời bạn chọn loại mảng: 1 chiều - 2 chiều");
                Console.Write("Nhấn 1 hoặc 2: ");
                string choose = Console.ReadLine();
                bool checkArray = true;
                if (choose == "1")
                {
                    do
                    {
                        Console.WriteLine("Bạn đã chọn mảng 1 chiều");
                        Console.Write("Vui lòng nhập số phần tử của mảng: ");
                        int[] Array1;
                        int theElements;
                        string result = "";
                        try
                        {
                            theElements = int.Parse(Console.ReadLine());
                            Array1 = new int[theElements];
                            for (int i = 0; i < theElements; i++)
                            {
                                try
                                {
                                    Console.Write("Phẩn tử thứ {0}: ", i + 1);
                                    Array1[i] = int.Parse(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Nhập lại phần tử thứ {0}", i + 1);
                                    i--;
                                }
                            }
                            Console.WriteLine("Hiện thị phần tử của mảng");
                            for (int i = 0; i < theElements; i++)
                            {
                                
                                if (i == theElements - 1)
                                {
                                    result += Array1[i];
                                }
                                else
                                {
                                    result += Array1[i] + ",";
                                }
                                
                            }
                            Console.WriteLine("[" + result + "]");
                            checkArray = false;
                        }
                        catch
                        {
                            Console.WriteLine("Vui lòng nhập số phẩn tử của mảng");
                            Console.Clear();
                            checkArray = true;
                        }
                    }
                    while (checkArray);
                }
                else if (choose == "2")
                {
                    do
                    {
                        Console.WriteLine("Bạn đã chọn mảng 2 chiều");
                        int[,] Array2;
                        int theElementRows;
                        int theElementColumns;
                        string result = "";
                        try
                        {
                            Console.Write("Số phần tử của dòng: ");
                            theElementRows = int.Parse(Console.ReadLine());
                            Console.Write("Số phần tử của cột: ");
                            theElementColumns = int.Parse(Console.ReadLine());
                            Array2 = new int[theElementRows, theElementColumns];
                            for (int i = 0; i < theElementRows; i++)
                            {
                                Console.WriteLine("Dòng thứ {0}", i + 1);
                                for (int j = 0; j < theElementColumns; j++)
                                {
                                    try
                                    {
                                        Console.Write("Phẩn tử thứ [{0},{1}]: ", i, j);
                                        Array2[i, j] = int.Parse(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Nhập lại phần tử thứ {0}", i + 1);
                                        i--;
                                    }
                                }

                            }
                            Console.WriteLine("Hiện thị phần tử của mảng");
                            for (int i = 0; i < theElementRows; i++)
                            {
                                for (int j = 0; j < theElementColumns; j++)
                                {
                                    result += Array2[i, j] + ",";
                                }
                                if (i == theElementRows - 1)
                                {
                                    
                                }
                                else
                                {
                                    result += "\n";
                                }
                            }
                            Console.WriteLine("[" + result + "]");
                            checkArray = false;
                        }
                        catch
                        {
                            Console.WriteLine("Vui lòng nhập số phẩn tử của mảng");
                            Console.Clear();
                            checkArray = true;
                        }
                    }
                    while (checkArray);
                }
                else
                {
                    Console.WriteLine("Vui lòng chọn mảng 1 chiều hoặc 2 chiều");
                }
                Console.WriteLine("Bạn có muốn tiếp tục: y/n");
                do
                {
                    check = Console.ReadLine();
                    if (check.ToLower() != "y" && check.ToLower() != "n")
                    {
                        Console.WriteLine("Vui lòng chọn y/n");
                    }

                } while (check == "");
            }
            while (check.ToLower() == "y");
        }
        static void Bai2()
        {
            string check;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Mảng 1 chiều");
                Console.WriteLine("2. Mảng 2 chiều");
                Console.WriteLine("Mời bạn chọn loại mảng: 1 chiều - 2 chiều");
                Console.Write("Nhấn 1 hoặc 2: ");
                string choose = Console.ReadLine();
                bool checkArray = true;
                if (choose == "1")
                {
                    do
                    {
                        Console.WriteLine("Bạn đã chọn mảng 1 chiều");
                        Console.Write("Vui lòng nhập số phần tử của mảng: ");
                        int[] Array1;
                        int theElements;
                        string result = "";
                        Random rd = new Random();
                        try
                        {
                            theElements = int.Parse(Console.ReadLine());
                            Array1 = new int[theElements];
                            for (int i = 0; i < theElements; i++)
                            {
                                Array1[i] = rd.Next(1, 100);
                            }
                            Console.WriteLine("Hiện thị phần tử của mảng");
                            for (int i = 0; i < theElements; i++)
                            {

                                if (i == theElements - 1)
                                {
                                    result += Array1[i];
                                }
                                else
                                {
                                    result += Array1[i] + ",";
                                }

                            }
                            Console.WriteLine("[" + result + "]");
                            checkArray = false;
                        }
                        catch
                        {
                            Console.WriteLine("Vui lòng nhập số phẩn tử của mảng");
                            Console.Clear();
                            checkArray = true;
                        }
                    }
                    while (checkArray);
                }
                else if (choose == "2")
                {
                    do
                    {
                        Console.WriteLine("Bạn đã chọn mảng 2 chiều");
                        int[,] Array2;
                        int theElementRows;
                        int theElementColumns;
                        string result = "";
                        Random rd = new Random();
                        try
                        {
                            Console.Write("Số phần tử của dòng: ");
                            theElementRows = int.Parse(Console.ReadLine());
                            Console.Write("Số phần tử của cột: ");
                            theElementColumns = int.Parse(Console.ReadLine());
                            Array2 = new int[theElementRows, theElementColumns];
                            for (int i = 0; i < theElementRows; i++)
                            {
                                for (int j = 0; j < theElementColumns; j++)
                                {
                                    Array2[i, j] = rd.Next(1, 100);
                                }

                            }
                            Console.WriteLine("Hiện thị phần tử của mảng");
                            for (int i = 0; i < theElementRows; i++)
                            {
                                for (int j = 0; j < theElementColumns; j++)
                                {
                                    result += Array2[i, j] + ",";
                                }
                                if (i == theElementRows - 1)
                                {

                                }
                                else
                                {
                                    result += "\n";
                                }
                            }
                            Console.WriteLine("[" + result + "]");
                            checkArray = false;
                        }
                        catch
                        {
                            Console.WriteLine("Vui lòng nhập số phẩn tử của mảng");
                            Console.Clear();
                            checkArray = true;
                        }
                    }
                    while (checkArray);
                }
                else
                {
                    Console.WriteLine("Vui lòng chọn mảng 1 chiều hoặc 2 chiều");
                }
                Console.WriteLine("Bạn có muốn tiếp tục: y/n");
                do
                {
                    check = Console.ReadLine();
                    if (check.ToLower() != "y" && check.ToLower() != "n")
                    {
                        Console.WriteLine("Vui lòng chọn y/n");
                    }

                } while (check == "");
            }
            while (check.ToLower() == "y");
        }
        static void Bai3()
        {
            string check;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Mảng 1 chiều");
                Console.WriteLine("2. Mảng 2 chiều");
                Console.WriteLine("Mời bạn chọn loại mảng: 1 chiều - 2 chiều");
                Console.Write("Nhấn 1 hoặc 2: ");
                string choose = Console.ReadLine();
                bool checkArray = true;
                if (choose == "1")
                {
                    do
                    {
                        Console.WriteLine("Bạn đã chọn mảng 1 chiều");
                        Console.Write("Vui lòng nhập số phần tử của mảng: ");
                        int[] Array1;
                        int theElements;
                        string result = "";
                        try
                        {
                            theElements = int.Parse(Console.ReadLine());
                            Array1 = new int[theElements];
                            for (int i = 0; i < theElements; i++)
                            {
                                try
                                {
                                    Console.Write("Phẩn tử thứ {0}: ", i + 1);
                                    Array1[i] = int.Parse(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Nhập lại phần tử thứ {0}", i + 1);
                                    i--;
                                }
                            }
                            Console.WriteLine("Hiện thị phần tử của mảng");
                            for (int i = 0; i < theElements; i++)
                            {

                                if (i == theElements - 1)
                                {
                                    result += Array1[i];
                                }
                                else
                                {
                                    result += Array1[i] + ",";
                                }

                            }
                            Console.WriteLine("[" + result + "]");
                            Console.WriteLine("Phần tử lớn nhất của mảng: {0}", FindMax1(Array1));
                            Console.WriteLine("Phần tử nhỏ nhất của mảng: {0}", FindMin1(Array1));
                            checkArray = false;
                        }
                        catch
                        {
                            Console.WriteLine("Vui lòng nhập số phẩn tử của mảng");
                            Console.Clear();
                            checkArray = true;
                        }
                    }
                    while (checkArray);
                }
                else if (choose == "2")
                {
                    do
                    {
                        Console.WriteLine("Bạn đã chọn mảng 2 chiều");
                        int[,] Array2;
                        int theElementRows;
                        int theElementColumns;
                        string result = "";
                        try
                        {
                            Console.Write("Số phần tử của dòng: ");
                            theElementRows = int.Parse(Console.ReadLine());
                            Console.Write("Số phần tử của cột: ");
                            theElementColumns = int.Parse(Console.ReadLine());
                            Array2 = new int[theElementRows, theElementColumns];
                            for (int i = 0; i < theElementRows; i++)
                            {
                                Console.WriteLine("Dòng thứ {0}", i + 1);
                                for (int j = 0; j < theElementColumns; j++)
                                {
                                    try
                                    {
                                        Console.Write("Phẩn tử thứ [{0},{1}]: ", i, j);
                                        Array2[i, j] = int.Parse(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Nhập lại phần tử thứ {0}", i + 1);
                                        i--;
                                    }
                                }

                            }
                            Console.WriteLine("Hiện thị phần tử của mảng");
                            for (int i = 0; i < theElementRows; i++)
                            {
                                for (int j = 0; j < theElementColumns; j++)
                                {
                                    result += Array2[i, j] + ",";
                                }
                                if (i == theElementRows - 1)
                                {

                                }
                                else
                                {
                                    result += "\n";
                                }
                            }
                            Console.WriteLine("[" + result + "]");
                            Console.WriteLine("Phần tử lớn nhất của mảng: {0}", FindMax2(Array2, theElementRows, theElementColumns));
                            Console.WriteLine("Phần tử nhỏ nhất của mảng: {0}", FindMin2(Array2, theElementRows, theElementColumns));
                            checkArray = false;
                        }
                        catch
                        {
                            Console.WriteLine("Vui lòng nhập số phẩn tử của mảng");
                            Console.Clear();
                            checkArray = true;
                        }
                    }
                    while (checkArray);
                }
                else
                {
                    Console.WriteLine("Vui lòng chọn mảng 1 chiều hoặc 2 chiều");
                }
                Console.WriteLine("Bạn có muốn tiếp tục: y/n");
                do
                {
                    check = Console.ReadLine();
                    if (check.ToLower() != "y" && check.ToLower() != "n")
                    {
                        Console.WriteLine("Vui lòng chọn y/n");
                    }

                } while (check == "");
            }
            while (check.ToLower() == "y");
        }
        static void Choose()
        {
            bool ok = true;
            do
            {
                try
                {
                    Console.WriteLine("Bài thầy Hậu giao");
                    
                    Console.WriteLine("1. Nhập và hiển thị mảng");
                    Console.WriteLine("2. Nhập và hiển thị mảng (\"ngẫu nhiên\")");
                    Console.WriteLine("3. Tìm giá trị lớn nhất, nhỏ nhất");
                    Console.Write("\n\n\n\n\nChọn bài: ");
                    int choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            {
                                Bai1();
                                break;
                            }
                        case 2:
                            {
                                Bai2();
                                break;
                            }
                        case 3:
                            {
                                Bai3();
                                break;
                            }
                    }
                    ok = false;
                }
                catch
                {
                    ok = true;
                }
            }
            while (ok);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Choose();
        }
    }
}
