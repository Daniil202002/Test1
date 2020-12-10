using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_from_set_user_parameter5
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ведите кол-ыо элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            int count = 0;
            List<int> ch = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + "-е значение");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int el in mas)
            {
                if (el % 3 == 0)
                {
                    ch.Add(el);
                    count++;
                }
            }
            if (count > 0)
            {
                foreach (int el1 in ch)
                {
                    Console.WriteLine("Число кратное трем: " + el1);
                }
            }
            else
            {
                Console.WriteLine("Нет чисел кратных трем");
            }
        }
    }
}