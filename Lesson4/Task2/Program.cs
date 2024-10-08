/* Создать двумерный массив, состоящий из целый чисел.
Вывести на экран "интересные" элементы массива.
Назовем число "интересным", если его сумма цифр четная.
 */

// Метод создания двумерного массива

int[,] CreateMatrix(int rowCount, int colomnCount, int minValue, int maxValue)
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

// Метод для проверки элемента массива на условие задачи

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false; // оператор else необязателен, так как если не попадем в if, автоматически попадем на return false
}

// Метод для получения суммы цифр в числе

int GetSumOfDigits(int value)
{
    int sum = 0;

    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

// Метод для вывода исходного массива

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

// Основная программа

int[,] arr = CreateMatrix(3, 5, 0, 1000);

ShowMatrix(arr);

foreach (int e in arr) // не предназначен для изменения элементов массива
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}
