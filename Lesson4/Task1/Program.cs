/* Задача 1.
Создать двумерный массив с размерами 3х5,
состоящий из целый чисел.
Вывести его элементы на экран.
 */

// Метод для создания двумерных массивов

int[,] CreateMatrix(int rowCount, int columsCount)
{
    // Создаем массив

    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random(); // ресурсоемкие операции лучше выносить за пределы циклов
    for (int i = 0; i < matrix.GetLength(0); i++)
    // matrix.GetLength(0) - требуем запросить количество строк в двумерном массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        // matrix.GetLength(1) - требуем запросить количество столбцов (элементов в строке) в двумерном массиве
        {
            matrix[i, j] = rnd.Next(1, 11); // обращение к элементу массива i - строка, j - столбец
        }
    }
    return matrix;
}

// Метод для вывода на экран

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    // matrix.GetLength(0) - требуем запросить количество строк в двумерном массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        // matrix.GetLength(1) - требуем запросить количество столбцов (элементов в строке) в двумерном массиве
        {
            Console.Write($"{matrix[i, j]} "); // обращение к элементу массива i - строка, j - столбец
        }
        Console.WriteLine(); // Добавлен перенос на новую строку, чтобы массивы выводились таблицей
    }
}

 // Вызов методов

int[,] matrix = CreateMatrix(3,5);
ShowMatrix(matrix);