/* Задача 3: Напишите программу, которая перевернёт
одномерный массив (первый элемент станет
последним, второй – предпоследним и т.д.)

Пример
[1 3 5 6 7 8] => [8 7 6 5 3 1] */

// Метод создания массива из случайных чисел

int[] CreatArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

// Метод для "переворота" массива

int[] TurnArray (int[] array)
{
    int temp;
    int index = array.Length-1;

    for (int i = 0; i < array.Length/2; i++) // i <= array.Length/2 дважды меняет центральные значения при четном количестве массива
    {
        temp = array[index];
        array[index] = array[i];
        array[i] = temp;

        index--;
    }
    return array;
}

// Метод для вывода в консоль

void PrintArray( int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length-1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.Write("]");
}

// Основная программа

Console.Write("Введите размер массива: ");
int input = Convert.ToInt32(Console.ReadLine());

// Вызов методов

int[] arr = CreatArrayRndInt(input,0, 9);
PrintArray(arr);
Console.Write(" => ");
int[] arrTurned = TurnArray(arr);
PrintArray(arrTurned);
