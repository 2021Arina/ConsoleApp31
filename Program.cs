
// Задана матрица A [n, n] действительных чисел.
// "Перевернуть" в ней главную и побочную диагонали.

using System;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Input(double[,] mas)
        {
            Random rand = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    mas[i, j] = rand.Next(50) + rand.NextDouble() * 2 - 10;
        }
        static void Printf(double[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write("{0,8:F1} ", mas[i, j]);
                Console.WriteLine();
            }
        }
        static void Main()
        {
            try
            {
                double k;
                Console.Write(" Введите количество строк и столбцов массива, n = ");
                int n = int.Parse(Console.ReadLine());
                double[,] Mas = new double[n, n];
                Input(Mas);
                Console.WriteLine(" ");
                Printf(Mas);
                Console.WriteLine(" ");
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = 0; j < n / 2; j++)
                    {
                        if (i == j)
                        {
                            k = Mas[i, j];
                            Mas[i, j] = Mas[n - i - 1, n - i - 1];
                            Mas[n - i - 1, n - i - 1] = k;
                        }
                    }
                }

                for (int i = n / 2; i < n; i++)
                {
                    for (int j = 0; j < n / 2; j++)
                    {
                        if (j == n - 1 - i)
                        {
                            k = Mas[i, j];
                            Mas[i, j] = Mas[j, i];
                            Mas[j, i] = k;
                        }
                    }
                }
                Console.WriteLine("\t Изменённый массив: \n");
                Printf(Mas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
