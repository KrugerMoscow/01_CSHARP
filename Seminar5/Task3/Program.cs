/* Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива.
Пример
2 3 4 3
4 3 4 1 => [3 3 5]
2 9 5 4 */

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

// Метод для создания одномерного массима по строкам из думерного

double[] GetAverageArrayRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = (double)sum / matrix.GetLength(1); // (double)sum - преобразование в дробный тип данных, иначе (int) / (int) = (int)
    }

    return array;
}

// Метод вывода в консоль одномерного массива

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}

// Основной код

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
double[] arr = GetAverageArrayRows(array2d);
PrintArray(arr);