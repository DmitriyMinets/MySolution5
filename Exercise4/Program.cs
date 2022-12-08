using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line, column;
            {
                Console.Write("Введите кол-во строк в матрице: ");
                int.TryParse(Console.ReadLine(), out line);
                Console.Write("Введите кол-во столбцов в матрице: ");
                int.TryParse(Console.ReadLine(), out column);
            }

            int[,] matrixOne, matrixTwo, sumMatrix;
            {
                matrixOne = new int[line, column];
                matrixTwo = new int[line, column];
                sumMatrix = new int[line, column];
            }


            SetRandomValuesInMatrix(matrixOne);
            SetRandomValuesInMatrix(matrixTwo);

            SumMatrix(matrixOne, matrixTwo, sumMatrix);

            Console.WriteLine("Матрица №1");
            PrintMatrix(matrixOne);
            Console.WriteLine("Матрица №2");
            PrintMatrix(matrixTwo);

            //Заполним матрицу рандомными значениями
            int[,] SetRandomValuesInMatrix(int[,] array)
            {
                Random randomValue = new Random();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = randomValue.Next(-200, 200);
                    }
                }
                return array;
            }
            //Суммируем матрицы и возвращаем проссумированую матрицу
            int[,] SumMatrix(int[,] matrix1, int[,] matrix2, int[,] sumMat)
            {
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        sumMat[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }
                return sumMat;
            }
            //Метод для вывода матриц
            void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write("{0}{1}", matrix[i, j], j == (matrix.GetLength(1) - 1) ? "" : " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма матриц");
            PrintMatrix(sumMatrix);
        }
    }
}