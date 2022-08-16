﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число строк m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = FillMatrixRandomNumbers(m, n);

PrintMatrix(matrix);

double[,] FillMatrixRandomNumbers(int rows, int columns)
{
    double[,] _matrix = new double[rows, columns];
    Random rand = new Random();

    for(int i = 0; i < _matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < _matrix.GetLength(1); j ++)
        {
            _matrix[i, j] = rand.NextDouble() * 100;
        }
    }

    return _matrix;
}

void PrintMatrix(double[,] _matrix)
{
        for(int i = 0; i < _matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < _matrix.GetLength(1); j ++)
        {
            Console.Write(Math.Round(_matrix[i,j], 1) + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте размерность двумерного массива m * n :");
Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
for(int i = 0; i < m ; i ++)
{
    for(int j = 0; j < n; j ++)
    {
        matrix[i,j] = new Random().NextDouble() * 100;
        Console.Write(Math.Round(matrix[i,j], 1) + " ");
    }
    Console.WriteLine();
}
