// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
            Console.Write(j < matrix.GetLength(1) - 1 ? " " : "");
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine("Введите размеры двумерного массива:");
Console.Write("Введите количество строк m: ");
int rowsM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int columnsN = Convert.ToInt32(Console.ReadLine());
double[,] randomMatrix = CreateMatrixRndDouble(rowsM, columnsN, -5, 5);
PrintMatrix(randomMatrix);
