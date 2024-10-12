/* Задание 3: Транспонирование двумерного массива
Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
транспонирует массив (меняет строки и столбцы местами).
Пример входных данных:
1 2
3 4
5 6
Пример результата:
1 3 5
2 4 6
 */

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

// Метод для замены строк на столбцы

int[,] ChangeRowtoColumn (int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            newMatrix[i,j] = matrix[j,i];
        }
    }
    return newMatrix;
}

// Основная программа

int[,] array2d = CreateMatrixRndInt(3,3,0,11);
PrintMatrix(array2d);
Console.WriteLine("Транспонирую массив:");
int[,] result = ChangeRowtoColumn(array2d);
PrintMatrix(result);
