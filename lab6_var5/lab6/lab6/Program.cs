using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\test.txt";
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Словом считаем последовательность символов, отделённую пробелом.
                    string[] words = line.Split(new char[] { ' ' });
                    for (int i = 0; i < words.Length - 1; i += 2)
                    {
                        // Переставляем местами.
                        Console.Write(words[i + 1] + " " + words[i] + " ");
                    }
                    // Если число слов нечётное, последнее просто дописываем в конец.
                    if (words.Length % 2 != 0)
                        Console.WriteLine(words[words.Length - 1]);
                    Console.WriteLine();
                    Console.ReadKey(true);
                }
            }
        }
    }
}