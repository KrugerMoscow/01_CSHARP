/* Задача 4*(не обязательная): Задайте двумерный массив
из целых чисел. Напишите программу, которая удалит
строку и столбец, на пересечении которых расположен
наименьший элемент массива. Под удалением
понимается создание нового двумерного массива без
строки и столбца

Пример

4 3 1 => 2 6
2 6 9    4 6
4 6 2 */

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

// Поиск наименьшего значения в массиве

(int rowMinNum, int columnMinNum) GetCoordinateMinNum(int[,] matrix)
{
    int rowMinNum = 0;
    int columnMinNum = 0;
    int minNum = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minNum)
            {
                minNum = matrix[i, j];
                rowMinNum = i;
                columnMinNum = j;
            }
        }
    }
    return (rowMinNum, columnMinNum);
}

// Поиск значений равных min и печать без них

void PrintMatrixWithOutMinNum(int[,] matrix, int rowMinNum, int columnMinNum)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != rowMinNum)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != columnMinNum)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
            }
        }
        Console.WriteLine();
    }
}

//Основной код

int[,] array2d = CreateMatrixRndInt(4, 3, 0, 10);
PrintMatrix(array2d);

(int row, int column) coordinate = GetCoordinateMinNum(array2d);
int row = coordinate.row;
int column = coordinate.column;

Console.Write($"Координаты минимального числа в массиве: ({row},{column})");
PrintMatrixWithOutMinNum(array2d, row, column);
