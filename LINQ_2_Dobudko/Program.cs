using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ_2_Dobudko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество чисел в массиве:");
            int count = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[count];
            Console.WriteLine("Введите число, больше которого должны быть квадраты чисел массива:");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите {i + 1} число:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //IEnumerable<double> num = from i in numbers where Math.Pow(i, 2) > N select i;

            var res = numbers.Select((a, ind) => new { value = a, index = ind, square = Math.Pow(a, 2) });


            Console.WriteLine($"Число и его квадрат массива, который больше {N}:");
            foreach (var i in res.Where(item => item.square > N))
            {
                Console.WriteLine("{" + $"Число = {i.value}, Ind = {i.index}, Kv = {i.square}" + "}");
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Количество чисел в массиве:");
    //        int count = Convert.ToInt32(Console.ReadLine());
    //        double[] numbers = new double[count];
    //        Console.WriteLine("Введите число, больше которого должны быть квадраты чисел массива:");
    //        int N = Convert.ToInt32(Console.ReadLine());
    //        int index = 0;

    //        for (int i = 0; i < count; i++)
    //        {
    //            Console.WriteLine($"Введите {i + 1} число:");
    //            numbers[i] = Convert.ToInt32(Console.ReadLine());
    //        }

    //        //IEnumerable<double> num = from i in numbers where Math.Pow(i, 2) > N select i;
            
    //        IEnumerable<double> num = numbers.Where(i => Math.Pow(i, 2) > N);

    //        Console.WriteLine($"Число и его квадрат массива, который больше {N}:");
    //        foreach (double i in num)
    //        {
    //            for (int j = 0; j<count; j++)
    //            {
    //                if (i == numbers[j])
    //                {
    //                    index = j;
    //                    Console.WriteLine("{Число = " + i + ", Ind = "+ index + ", Kv = " + Math.Pow(i, 2) + "}");
    //                }
    //            }
    //        }
    //    }
    //}
}
