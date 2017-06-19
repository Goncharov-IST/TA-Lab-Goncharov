using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = 0, x, y = 0;
            // Задание 1
            Console.WriteLine("Первое задание");
            Console.Write("x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("R=");
            R = Convert.ToDouble(Console.ReadLine());
            if (-4 <= x && x < -2)
                y = 1 * x + 3;
            else if (-2 <= x && x < 4)
                y = 0.5 * x;
            else if (4 <= x && x < 6)
                y = -2;
            else if (6 <= x && x < 10)
                y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x - 8, 2)) - 2;
            else
                Console.WriteLine("Неопределена");
            Console.WriteLine("y=" + y);
            Console.ReadKey(true);
            // Задание 2
            Console.WriteLine("\nЗадание 2");
            Console.Write("x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            y = Convert.ToDouble(Console.ReadLine());
            if (-R <= x && x <= 0 && y >= -Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2)) && y <= x + R)
                Console.WriteLine("Пара (x,y) принадлежит заданной области");
            else if (R >= x && x >= 0 && y <= Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2)) && y >= 0)
                Console.WriteLine("Пара (x,y) принадлежит заданной области");
            else
                Console.WriteLine("Пара (x,y) не принадлежит заданной области");
            Console.ReadKey(true);
        }
    }
}