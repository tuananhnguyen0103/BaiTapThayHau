using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommomSubSequence
{
    class Program
    {
        static void LCS(string str1, string str2)
        {
            // Độ dài của 2 chuỗi
            int lengStr1 = str1.Length;
            int lengStr2 = str2.Length;
            
            // Tạo ma trận có chiều bằng độ dài của 2 chuỗi cộng thêm 1
            int[,] LCSelements = new int[lengStr1 + 1, lengStr2 + 1];

            // Dùng 2 vòng for để gán giá trị cho 
            for (int i = 0; i <= lengStr1; i++)
            {
                for (int j = 0; j <= lengStr2; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        LCSelements[i, j] = 0;
                    }
                    else if (str1[i - 1] == str2[j - 1])
                    {
                        LCSelements[i, j] = LCSelements[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        LCSelements[i, j] = Math.Max(LCSelements[i - 1, j], LCSelements[i, j - 1]);
                    }
                }
            }

            
            int index = LCSelements[lengStr1, lengStr2];
            char[] LCSchar = new char[index];
            int strRow = lengStr1, strCol = lengStr2;
            while (strCol > 0 && strRow > 0)

            {
                if (str1[strRow - 1] == str2[strCol - 1])
                {
                    LCSchar[index-1] = str1[strRow - 1];
                    strRow--;strCol--;index--;
                }
                else
                {
                    if (LCSelements[strRow - 1, strCol] > LCSelements[strRow, strCol - 1])
                    {
                        strRow--;
                    }
                    else
                    {
                        strCol--;
                    }
                }
            }
            foreach (var item in LCSchar)
            {
                Console.Write(item+"\t");
            }
        }
        static void Main(string[] args)
        {
            string str1 = "adcdf";
            string str2 = "badef";
            LCS(str1, str2);
            Console.ReadKey();

        }
    }
}
