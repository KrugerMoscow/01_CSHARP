/* Задание 3: Поиск среднего значения массива
Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов
массива. */

Console.Write("Введите массив чисел через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

double sum = 0; // среднее арифметическое может быть дробное число

for (int i = 0; i < array.Length; i++)
{
    sum += array[i]; // sum = sum + array[i];
}

sum /= array.Length; // sum = sum / array.Length

Console.WriteLine(sum);
