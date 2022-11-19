// Задача 50. Напишите программу, которая
// на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

// В условии нет уточнения, какого типа должны быть элементы массива
// используем методы из задачи 47 - вещественные числа

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

double[,] randomMatrix = CreateMatrixRndDouble(3, 4, -5, 5);
PrintMatrix(randomMatrix);

Console.WriteLine("Введите позиции элемента массива:");
Console.Write("Введите номер строки: ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

// Предполагаем, что пользователь ведёт отсчёт позиций от 0
if
(
    targetRow >= 0 && targetRow < randomMatrix.GetLength(0)
    &&
    targetColumn >= 0 && targetColumn < randomMatrix.GetLength(1)
)
{
    Console.WriteLine($"В позиции {targetRow}, {targetColumn} находится элемент {randomMatrix[targetRow, targetColumn]}");
}
else Console.WriteLine($"В исходном массиве нет элемента в позиции {targetRow}, {targetColumn}");
