// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
            Console.Write(j < matrix.GetLength(1) - 1 ? " " : "");
        }
        Console.WriteLine();
    }

}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(i < array.Length - 1 ? ", " : "");
    }
    Console.WriteLine();
}

double[] ColumnsAverage(int[,] matrix)
{
    double[] averagesArray = new double[matrix.GetLongLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averagesArray[j] += matrix[i, j];
        }
        averagesArray[j] /= matrix.GetLength(0);
        averagesArray[j] = Math.Round(averagesArray[j], 1);
    }
    return averagesArray;
}

int[,] randomMatrix = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(randomMatrix);
double[] columnsAverage = ColumnsAverage(randomMatrix);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(columnsAverage);
