using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3. Задан одномерный массив А[1..15]. Определить количество 
   четных положительных элементов массива. */

namespace Lab_4_2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[15];
            Random r = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(-10, 10);
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\n");

            // Классический способ.
            int count = 0;
            for (int i = 0; i < A.Length; i++)
                if (A[i] > 0 && A[i] % 2 == 0)
                    count++;
            Console.WriteLine($"Количество четных положительных элементов = {count}");

            // С помощью Linq.
            Console.WriteLine($"Количество четных положительных элементов = " +
                $"{A.Where(x => x > 0 && x % 2 == 0).Count()}");

            Console.ReadKey();
        }
    }
}
