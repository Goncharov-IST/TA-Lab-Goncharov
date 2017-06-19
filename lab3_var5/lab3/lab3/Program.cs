using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=-4, y=-1, dx=1;
            Console.WriteLine("Вариант 5");
            //Задание 1
            Console.WriteLine("Первое задание");
            Console.WriteLine("Значения кусочной функции:");
            Console.WriteLine("    _______________");
            Console.WriteLine("   |   X   |   Y   |");
            Console.WriteLine("   |_______|_______|");
            for(dx = 1; x < 11; x = x + dx)
            {
                if (-4 <= x && x < -2)
                    y = x + 3;
                else if (-2 <= x && x < 4)
                    y = -0.5 * x;
                else if (4 <= x && x < 6)
                    y = -2;
                else if (6 <= x && x < 10)
                    y = Math.Sqrt(Math.Pow(2, 2) - Math.Pow(x - 8, 2)) - 2;
                Console.WriteLine("   |" + String.Format("{0,4:0.#}", x) + "   |" + String.Format("{0,5:0.##}", y) + "  |");
            }
            Console.WriteLine("   |_______|_______|");
            //Задание 2
            Console.WriteLine("Второе задание");
            Console.WriteLine();
            double R = 8, a, b=0;
            Console.WriteLine("Серия выстрелов по мишени:");
            Console.WriteLine("R=8");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("a=");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b=");
                b = Convert.ToDouble(Console.ReadLine());
                if (-R <= a && a <= 0 && b >= -Math.Sqrt(Math.Pow(R, 2) - Math.Pow(a, 2)) && b <= a + R)
                    Console.WriteLine("Принадлежит заданной области");
                else if (R >= a && a >= 0 && b <= Math.Sqrt(Math.Pow(R, 2) - Math.Pow(a, 2)) && b >= 0)
                    Console.WriteLine("Принадлежит заданной области");
                else
                    Console.WriteLine("Не принадлежит заданнй области");
            }
            //Задание 3
            Console.WriteLine("Третье задание");
            Console.WriteLine("\n\tРяд Тейлора для функции loG");
            Console.WriteLine("      ______________________________ ");
            Console.WriteLine("     |  x  |  loG   |  n  |   log   |");
            Console.WriteLine("     |_____|________|_____|_________|");
            Double  x_end=0.9, e = 0.001, log, loG;
            dx = 0.1;x = -0.9;
            while (x<=x_end)
            {
                Double last=0, sum=0;
                int n = 0;
                do
                {
                    last = Math.Pow(x, 2 * n + 1) / (2 * n + 1);
                    sum += last;
                    n++;
                } while (Math.Abs(last) > e);
                loG = 2 * sum;
                log = Math.Log((1+x) / (1-x));
                Console.WriteLine("     |" + String.Format("{0,5:0.#}", x) + "|" + String.Format("{0,8:0.####}", loG) + "|" + String.Format("{0,5:0}", n) + "|" + String.Format("{0,9:0.####}", log) + "|");
                Console.WriteLine("     |_____|________|_____|_________|");
                x = x + dx;
            }
            Console.ReadKey(true);
        }
    }
}