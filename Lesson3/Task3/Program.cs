// Функция для обнуления четных элементов массива

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) // проверка на четность, остаток от деления 0
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr) // функция для вывода на экран
{
    foreach (int e in arr) // используется foreach, так как значения в него копируются и не изменяются в исходных данных, e - имя переменной и может быть произвольным
    {
        Console.Write($"{e} "); // для цикла foreach обращение к массиву происходит через переменную e, а не arr[i]
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array); // вызов функции
PrintArray(array);