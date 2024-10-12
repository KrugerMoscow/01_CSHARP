/* Задание 4: Замена отрицательных элементов в двумерном массиве
Описание: Задайте двумерный массив. Замените все отрицательные числа на их
абсолютные значения.
Пример входных данных:
1 -2 3
-4 5 -6
7 -8 9
Пример результата:
1 2 3
4 5 6
7 8 9 */

// Метод создания двумерного массива

int[,] CreateMatrixRndInt(int rowCount, int columnCount, int minValue, int maxValue)
{
    int[,] matrix = new int[rowCount, columnCount];
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

// Метод замены отрицательных чисел на положительные

int[,] ChangeNegativeNumsToPositive(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 0)
            {
                newMatrix[i,j] = -matrix[i, j];
            }
            else
            {
                newMatrix[i,j] = matrix[i, j];
            }
        }
    }
    return newMatrix;
}

// Основная программа

int[,] array2d = CreateMatrixRndInt(4,3,-10,11);
PrintMatrix(array2d);
Console.WriteLine("Отрицательные значения заменены на абсолютные:");
int[,] result = ChangeNegativeNumsToPositive(array2d);
PrintMatrix(result);
