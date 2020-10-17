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
        static void lcs(string S1, string S2)
        {
            // S1 -> Row, S2 -> Col
            int lengtS1 = S1.Length, lengtS2 = S2.Length;

            int[,] LCS = new int[lengtS1+1, lengtS2+1];

            for (int i = 0; i <= lengtS1; i++)
            {
                for (int j = 0; j <= lengtS2; j++)
                {
                    if (i == 0|| j == 0)
                    {
                        LCS[i, j] = 0;
                    }
                    else if (S1[i - 1] == S2[j - 1])
                    {
                        LCS[i, j] = LCS[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        LCS[i, j] = Math.Max(LCS[i - 1, j], LCS[i, j - 1]);
                    }
                }
            }

            int index = LCS[lengtS1, lengtS2];
            char[] result = new char[index];
            while(index != 0)
            {
                if (S1[lengtS1 - 1] == S2[lengtS2 - 1])
                {
                    result[index - 1] = S1[lengtS1 - 1];
                    index--;lengtS1--;lengtS2--;
                }
                else
                {
                    if (LCS[lengtS1 - 1, lengtS2] > LCS[lengtS1, lengtS2 - 1])
                    {
                        lengtS1--;
                    }
                    else
                    {
                        lengtS2--;
                    }
                }
            }
            foreach (var item in result)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }

        /* Utility function to get max of 2 integers */
        

        // Driver code 
        public static void Main()
        {

            string S1 = "asdasdq";
            string S2 = "anisdacq";
            lcs(S1, S2);
            Console.ReadKey();
        }
    }
}
