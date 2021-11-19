using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ_Dobudko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество чисел в массиве:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i =0; i<n; i++) 
            {
                Console.WriteLine($"Введите {i+1} число:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

           //IEnumerable<int> num = from i in numbers where i % 2 == 0 select i;

            IEnumerable<int> num = numbers.Where(i => i%2 == 0);

           Console.WriteLine("Числа, которые производят остаток 0 после деления на 2:");

            foreach(int i in num) 
            {
                Console.Write(i+" ");
            }
        }
    }
}
