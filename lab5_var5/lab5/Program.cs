using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        private static int sum1;
        private static int sum2;
        static void Main(string[] args)
        {
            int N = 3;
            Random ran = new Random();
            int[,] x = new int[3, 3];
            int[,] z = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    x[i, j] = ran.Next(-5, 5);

                    Console.Write("{0}\t", x[i, j]);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < 3; j++)
            {
                int s = 0;
                bool fl = true;

                for (int k = 0; k < 3; k++)
                {
                    s += x[k, j];
                    if (x[k, j] < 0) fl = false;
                }

                if (fl)
                    Console.WriteLine("Сумма элементов столбца [{0}] = " + s, j + 1);
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i; j++)
                {
                    z[i, j] = x[N - j - 1, N - i - 1];
                }
            }
            for (int n = N; n > 0; n--)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    sum1 += Math.Abs(x[i, N - i - 2]);
                    sum2 += Math.Abs(z[i, N - i - 2]);
                }
                N--;
            }
            int min;
            if (sum1 < sum2) min = sum1;
            else min = sum2;
            Console.WriteLine("Up: " + sum1 + "   " + "Down: " + sum2 + "\n" + "\n");
            Console.WriteLine("Минимальная сумма: " + min);
            Console.ReadKey();
        }
    }
}