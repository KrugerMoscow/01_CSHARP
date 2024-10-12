/* Задание 1: Поиск максимального элемента в каждой строке
Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
находит максимальный элемент в каждой строке массива и выводит его.
Пример входных данных:
1 3 5 7
2 4 6 8
9 10 11 12
Пример результата:
Максимальный элемент в строке 0: 7
Максимальный элемент в строке 1: 8
Максимальный элемент в строке 2: 12
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

// Метод поиска максимального числа в каждоый строке двумерного массива

void PrintMaxNumInStrOfMatrix(int[,] matrix)
{
    int maxNum;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        maxNum = matrix[i,0];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] > maxNum)
            {
                maxNum = matrix[i,j];
            }
        }
        Console.WriteLine($"Максимальный элемент в строке {i}: {maxNum}");
    }
}

// Основная программа

int[,] array2d = CreateMatrixRndInt(3,4,0,10);
PrintMatrix(array2d);
PrintMaxNumInStrOfMatrix(array2d);