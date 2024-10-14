/* Задайте массив символов (тип char []). Создайте строку из
символов этого массива.
Указание
Конструктор строки вида string(char []) не использовать.
Пример
[‘a’, ‘b’, ‘c’, ‘d’] => “abcd” */

// Метод для составления строки из символов

string CharArrayToString(char[] arr)
{
    string res = string.Empty; // Создание пустой строки
    for (int i = 0; i < arr.Length; i++)
    {
        res += arr[i];
    }
    return res;
}

char[] array = { 'a', 'b', 'c', 'd', 'e', 'f' };
string result = CharArrayToString(array);
Console.WriteLine(result);

