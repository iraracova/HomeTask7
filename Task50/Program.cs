// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число строк m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixRandomNumbers(m, n);

PrintMatrix(matrix);

int[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] _matrix = new int[rows, columns];
    Random rand = new Random();

    for(int i = 0; i < _matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < _matrix.GetLength(1); j ++)
        {
            _matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return _matrix;
}

void PrintMatrix(int[,] _matrix)
{
        for(int i = 0; i < _matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < _matrix.GetLength(1); j ++)
        {
            Console.Write(_matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число позиции строк i:");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число позиции столбцов j:");
int l = Convert.ToInt32(Console.ReadLine());

    if(k > m || l > n)
    {
        Console.WriteLine("Такого элемента нет!");
    }
    else
    {
        Console.WriteLine(matrix[k, l]);
    }

        