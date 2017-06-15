using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] )
        {
            double m, n, z2;

            Console.Write("Введите m: ");
            string buf = Console.ReadLine();
            double m = double.Parse(buf);

            Console.Write("Введите n: ");
            string buf = Console.ReadLine();
            double n = double.Parse(buf);

            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine("z2=", z2);
        }
    }
}
