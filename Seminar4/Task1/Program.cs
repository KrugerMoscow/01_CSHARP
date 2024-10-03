/* Простые числа - числа, которые не имеют делителя,
их можно разделить без остатка только на единицу и 
на самого себя.

Задайте одномерный массив, заполненный случайными
числами. Определите количество простых чисел в этом массиве.
Примеры
[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13] => 3 */

// Создание метода (функции)
// int[] - тип возвращаемых данных (возвращаем массив int);
// CreateArrayRndInt - имя метода
//(int size,int min, int max) - параметр метода, будет показывать размер массива, диапазон для чисел

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size]; // создание массива
    Random rnd = new Random();
    // Random - это класс, условно это файл, который называется Random,
    // в котором лежат команды (функции) для работы со случайными числами

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

// Создание метода для вывода в консоль

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

// Названия глобальных переменных не должны совпадать с названиями локальных переменных в методах

// Подсчет простых чисел CountPrimeNumbers

int CountPrimeNumbers(int[] array) // array - Название параметра может быть любое, оно локальное и может повторяться в других методах и быть не связанным с ними
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsPrime(array[i])) // если(if) число простое (IsPrime)? да(true)
        {
            count++;
        }
    }
    return count; // false
}

// Метод для проверки является ли число простым
// Чтобы понять простое ли число, достаточно в цикле дойти до его корня
bool IsPrime(int num)
{
    for (int i = 2; i <= Math.Sqrt(num); i++) // Math.Sqrt(num) - метод вычисления корня из числа num
    {
        if (num % i == 0) // если число можно поделить на любое из этого диапазона, то число не простое
        {
            return false;
        }
    }
    return true;
}

// Вызовы методов

int[] arr = CreateArrayRndInt(10, 1, 100); // Нужно приравнивать к переменной, так как возвращается массив int
PrintArray(arr); // Не нужно приравнивать к переменной, так как void ничего не возвращает

int countPrime = CountPrimeNumbers(arr);
Console.Write($" => {countPrime}");
