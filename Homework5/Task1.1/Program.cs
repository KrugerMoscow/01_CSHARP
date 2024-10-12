/* Задача 1: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.

Пример
4 3 1 (1,2) => 9
2 6 9 */

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

// Метод для печати входящих данных в виде массива

void GetInputArray(int[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]},");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write(") => ");
}

// Метод поиска и вывода элемента по координате

void PrintDigitOfMatrixByInputArr(int[,] matrix, int[] array)
{
    int digit = 0;

    if (array[0] >= matrix.GetLength(0) || array[1] >= matrix.GetLength(1) || array.Length > 2)
    {
        
        Console.WriteLine("Ошибка, такого элемента не существует!");
    }
    else
    {
        digit = matrix[array[0], array[1]];
        Console.WriteLine(digit);
    }
}

// Основной код

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);

Console.Write("Введите координаты элемента массива через запятую: ");
int[] input = Array.ConvertAll(Console.ReadLine().Split(","), Convert.ToInt32);

GetInputArray(input);
PrintDigitOfMatrixByInputArr(array2d,input);



