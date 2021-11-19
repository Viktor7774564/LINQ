using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ_3_Dobudko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк для хранения в массиве:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[n];
            string str = "";
            Console.WriteLine($"Введите {n} строк(строки, строку) для массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент [{i + 1}]:");
                words[i] = Convert.ToString(Console.ReadLine());
            }


            //IEnumerable<string> num = from i in words select i;

            IEnumerable<string> num = words;


            
            foreach (string i in num)
            {
               str += i + ", ";
               
            }

            str = str.Remove(str.Length-2,2);
            Console.WriteLine(str);
        }
    }
}
