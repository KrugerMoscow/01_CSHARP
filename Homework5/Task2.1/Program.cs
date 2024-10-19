/* Задача 2: Задайте двумерный массив. Напишите
программу, которая поменяет местами первую и
последнюю строку массива.

Пример

4 3 1    =>   4 6 2
2 6 9         2 6 9
4 6 2         4 3 1 */

// Метод создания двумерного массива

int[,] CreateMatrixRndInt(int rowCount, int colomnCount, int minValue, int maxValue)
{
    int[,] matrix = new int[rowCount, colomnCount];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return matrix;
}

// Метод для вывода двумерного массива

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

// Метод замены 0 строки на последнюю

int[,] ChangeFirstLineToLastLine(int[,] matrix)
{
    int temp;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[matrix.GetLength(0) - 1, j];
                matrix[matrix.GetLength(0) - 1, j] = temp;
            }
        }
    }
    return matrix;
}

// Основная программа

int[,] array2d = CreateMatrixRndInt(4, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine("Замена первой строки в массиве на последнюю: ");
ChangeFirstLineToLastLine(array2d);
PrintMatrix(array2d);
