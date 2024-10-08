/* Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты.
Пример
2 3 4 3    4 3 16 3
4 3 4 1 => 4 3 4 1
2 9 5 4    4 9 25 4
 */

// Метод создания двумерного массива

int[,] CreateMatrixRndInt(int rowCount, int colomnCount, int minValue, int maxValue)
{
    int[,] matrix = new int[rowCount, colomnCount];
    Random rnd = new Random();

    // цикл проходит по строкам
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    }

    //цикл проходит по столбцам
    /* for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    } */
    return matrix;
}

// Метод для вывода в консоль

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

// Метод для замены элементов на квадраты

void ElemEvenIndexesToSquare(int[,] matrix) // класс void,тк массив ссылочный тип данных, переменные не создаются,а передаются по ссылке
{
    for (int i = 0; i < matrix.GetLength(0); i+=2) // i=i+2 +2 потому что идем только по четным числам
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2) 
        {
            matrix[i,j]*=matrix[i,j];
        }
    }
}

// Основная программа

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

ElemEvenIndexesToSquare(array2d);
PrintMatrix(array2d);