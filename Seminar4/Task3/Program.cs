/* Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231 */

// Метод заполнения массива

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

// Метод для вывода массива в консоль

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + " ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.Write("]");
}

// Метода для формирования целого числа из массива

int CreateNumberFromArray(int[] array)
{
    int number = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        number = number * 10 + array[i];
    }
    
    return number;
}

Console.Write("Задайте размер массива от 1 до 8: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numN <= 0 || numN >= 9)
{
    Console.WriteLine("Ошибка ввода!");
}

else
{
    int[] arr = CreateArrayRndInt(numN, 0, 10); // 10 не входит в диапазон
    PrintArray(arr);
    int result = CreateNumberFromArray(arr);
    Console.Write($" => {result}");
}