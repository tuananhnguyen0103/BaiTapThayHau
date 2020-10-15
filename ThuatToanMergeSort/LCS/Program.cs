using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS
{
    class Program
    {
        /* Returns length of LCS for X[0..m-1], Y[0..n-1] */
        static int lcs(char[] X, char[] Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];

            /* Following steps build L[m+1][n+1]  
            in bottom up fashion. Note 
            that L[i][j] contains length of  
            LCS of X[0..i-1] and Y[0..j-1] */
            Console.WriteLine(m+1);
            Console.WriteLine(n+1);
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = max(L[i - 1, j], L[i, j - 1]);
                }
            }
            return L[m, n];
        }

        /* Utility function to get max of 2 integers */
        static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // Driver code 
        public static void Main()
        {

            String s1 = "Vu Chung Dung";
            String s2 = "Nguyen Tuan Anh";

            char[] X = s1.ToCharArray();
            char[] Y = s2.ToCharArray();
            int m = X.Length;
            int n = Y.Length;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.Write("Do dai cua chuoi la" + " " + lcs(X, Y, m, n));
            Console.ReadKey();
        }
    }
}
