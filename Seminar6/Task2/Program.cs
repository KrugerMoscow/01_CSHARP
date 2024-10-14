/* На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.
Указание
Метод строки ToCharArray() не использовать.
Пример
“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] */

// Метод для преобразования строки в массив символов

char[] StringToCharArray(string inputString)
{
    char[] strArray = new char[inputString.Length];
    for (int i = 0; i < inputString.Length; i++)
    {
        strArray[i] = inputString[i];
    }
    return strArray;
}

// Метод вывода в консоль одномерного массива

void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1)
        {
            Console.Write($"{array[i]},");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}


Console.Write("Введите запрос:");
string str = Console.ReadLine();
char[] resArray = StringToCharArray(str);
PrintArray(resArray);
