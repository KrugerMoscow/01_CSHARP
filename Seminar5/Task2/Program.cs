/* Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и
т.д.
Пример
2 3 4 3
4 3 4 1 => 2 + 3 + 5 = 10
2 9 5 4 */

// Метод для создания двумерного массива

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

// Метод для печати матрицы в консоль

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} "); // цифра в скобках - длина строки вывода, то есть 4 символа под одно значение matrix[i, j]
        }
        Console.WriteLine();
    }
}

// Метод для поиска суммы элементов по диагонали

int FindSumFromMainDiag(int[,] matrix)
{
    int sum = 0;

    // Вариант 1:
    /* int minSize = matrix.GetLength(0); // для матрицы 3х4
    if (matrix.GetLength(1) < minSize)
    {
        minSize = matrix.GetLength(1); // для матрицы 4х3
    }

    for (int i = 0; i < minSize; i++)
    {
        sum += matrix[i, i]; // sum=sum+matrix[i,i]; i и i потому что в индексы в диагонали будут равны [0,0], [1,1], [2,2]
    } */

    // Вариант 2:
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, i]; // sum=sum+matrix[i,i]; i и i потому что в индексы в диагонали будут равны [0,0], [1,1], [2,2]
    }

    return sum;
}

// Основная программа

int[,] array2d = CreateMatrixRndInt(4, 3, 0, 10);
PrintMatrix(array2d);
Console.Write(" => ");
int result = FindSumFromMainDiag(array2d);
Console.WriteLine(result);