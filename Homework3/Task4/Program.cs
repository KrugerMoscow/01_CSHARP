/* Задание 4: Удаление всех отрицательных чисел
Описание: Задайте массив целых чисел. Напишите программу, которая удаляет все
отрицательные числа из массива и возвращает новый массив, содержащий только
неотрицательные числа. */

Console.Write("Введите массив чисел через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

// Строчку выше посмотрел в инете, введенные числа разделяются пробелом, конвертируются и сохраняются в массив

int index = 0; // индекс чисел в массиве
int count = 0; // счетчик для проверки сколько всего отрицательных чисел

int index2 = 0; // Длина массива newArray

for (int i = 0; i < array.Length; i++) // определяем длину нового массива newArray
{
    if (array[i] >= 0)
    {
        index2++;
    }
}

int[] newArray = new int[index2]; // пустой массив для вывода положительных чисел в консоль

// Одно и тоже записал через цикл for и while
/* for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        count++;
    }
} */

while (index < array.Length) // считаем отрицательные числа
{
    if (array[index] < 0)
    {
        index++;
        count++;
    }
    
    else // без else цикл не попадаев в if и зацикливается, потому что значение index не изменяется
    {
        index++;
    }
}

if (count > array.Length - 1)
{
    Console.WriteLine("Все числа отрицательные!");
}

else
{
    int j = 0; // просто счетчик для изменения позиций в массиве newArray при записи новых значений

    for (int i = 0; i < array.Length; i++) // определяем и записываем положительные числа в новый массив
    {
        if (array[i] >= 0)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    Console.Write("[");

    for (int i = 0; i < newArray.Length; i++) // для вывода создал новый цикл
    {
        if (i != newArray.Length-1)
        {
            Console.Write(newArray[i] + " ");
        }

        else
        {
            Console.Write(newArray[i]);
        }
    }

    Console.Write("]");
}
