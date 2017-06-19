using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ar = new double[10];
            Random rand = new Random();
            double max = 0.0;

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Math.Round(rand.NextDouble() * 100 - 50, 1);
            }

            foreach (var i in ar)
                Console.WriteLine(i);

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                    max = ar[i];
            }

            Console.WriteLine("Максимальный элемент = {0}", max);

            /*
            double[] ar = new double[10];
            Random rand = new Random();
            int lastPositive = 0;
            double sum = 0.0;

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Math.Round(rand.NextDouble() * 100 - 50, 1);
            }

            foreach (var i in ar)
                Console.WriteLine(i);

            for (int i = ar.Length - 1; i >= 0; i--)
            {
                if (ar[i] > 0)
                {
                    lastPositive = i;
                    break;
                }
            }

            for (int i = 0; i < lastPositive; i++)
            {
                sum += ar[i];
            }
            Console.WriteLine("Сумма элементов до последнего положительного = {0}", sum);


            /*
            int first = 5;
            int last = 18;

            int[] ar = new int[10];
            int[] ar2 = new int[10];
            Random rand = new Random();

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rand.Next(-100, 101);
            }

            foreach (var i in ar)
                Console.WriteLine(i);

            Console.WriteLine();

            for (int i = 0, j = 0; i < ar.Length; i++)
            {
                if (Math.Abs(ar[i]) < first || Math.Abs(ar[i]) > last)
                {
                    ar2[j] = ar[i];
                    j++;
                }
            }

            foreach (var i in ar2)
                Console.WriteLine(i);
                */
        }
    }
}