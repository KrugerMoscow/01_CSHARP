/* Задача 3: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с
наименьшей суммой элементов.

Пример

4 3 1 => Строка с индексом 0
2 6 9
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

// Метод поиска суммы элементов в каждой строке массива и возврат в виде одномерного массива

int[] GetSumOfNumsInRow(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] += matrix[i, j];
        }
        Console.WriteLine($"Сумма элементов в строке {i}: {array[i]}");
    }
    return array;
}

// Метод поиска минимального значения в одномерном массиве

void PrintIndexOfMinNumInArr(int[] array)
{
    int minNum = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minNum)
        {
            minNum = array[i];
            index = i;
        }
    } 
    Console.WriteLine($"Наименьшая сумма элементов в строке {index}");
} 

// Основаная программа

int[,] array2d = CreateMatrixRndInt(4,3,0,10);
PrintMatrix(array2d);
int[] result = GetSumOfNumsInRow(array2d);
PrintIndexOfMinNumInArr(result);

