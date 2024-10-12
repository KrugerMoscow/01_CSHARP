/* Задание 2: Поиск суммы элементов в каждом столбце
Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
находит сумму элементов в каждом столбце массива и выводит её.

Пример входных данных:
1 2 3
4 5 6
7 8 9
10 11 12

Пример результата:
Сумма элементов в столбце 0: 22
Сумма элементов в столбце 1: 26
Сумма элементов в столбце 2: 30
 */

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

// Метод поиска суммы элементов в каждом слобце массива

void PrintSumOfNumsInColumn(int[,] matrix)
{
    int sum;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j]; 
        }
        Console.WriteLine($"Сумма элементов в столбце {j}: {sum}");
    }
}

// Основная программа

int[,] array2d = CreateMatrixRndInt(3,4,0,10);
PrintMatrix(array2d);
PrintSumOfNumsInColumn(array2d);