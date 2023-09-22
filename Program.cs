using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Array_and_strings
{
    using System;

    class Program
    {
        static void Main()
        {

            int[] A = new int[5];

            Console.WriteLine("Введите 5 чисел для массива A:");
            for (int i = 0; i < 5; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            double[,] B = new double[3, 4];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.NextDouble() * 100; 
                }
            }

            Console.WriteLine("Массив A:");
            foreach (var element in A)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Массив B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Находим общий максимальный элемент
            double maxA = A[0];
            double maxB = B[0, 0];

            foreach (var element in A)
            {
                if (element > maxA)
                    maxA = element;
            }

            foreach (var element in B)
            {
                if (element > maxB)
                    maxB = element;
            }

            double maxCommon = Math.Max(maxA, maxB);
            Console.WriteLine($"Максимальный элемент для обоих массивов: {maxCommon}");

            double minA = A[0];
            double minB = B[0, 0];

            foreach (var element in A)
            {
                if (element < minA)
                    minA = element;
            }

            foreach (var element in B)
            {
                if (element < minB)
                    minB = element;
            }

            double minCommon = Math.Min(minA, minB);
            Console.WriteLine($"Минимальный элемент для обоих массивов: {minCommon}");

            double sumA = 0;
            double sumB = 0;

            foreach (var element in A)
            {
                sumA += element;
            }

            foreach (var element in B)
            {
                sumB += element;
            }

            double sumTotal = sumA + sumB;
            Console.WriteLine($"Общая сумма всех элементов для обоих массивов: {sumTotal}");

            double productA = 1;
            double productB = 1;

            foreach (var element in A)
            {
                productA *= element;
            }

            foreach (var element in B)
            {
                productB *= element;
            }

            double productCommon = productA * productB;
            Console.WriteLine($"Общее произведение всех элементов обоих массивов: {productCommon}");

            double sumForA = 0;

            foreach (var element in A)
            {
                if (element % 2 != 0)
                    sumForA += element;
            }

            Console.WriteLine($"Сумма парных элементов массива A: {sumForA}");

            double sumForColumnsB = 0;

            for (int j = 0; j < 4; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sumForColumnsB += B[i, j];
                    }
                }
            }


            Console.WriteLine($"Сумма нечетных столбцов массива B: {sumForColumnsB}");

            Console.ReadLine();
        }
    }
}

