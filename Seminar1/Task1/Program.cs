using System;

/* Задача 1.
Напишите программу, которая на вход принимает два целых числа и проверяет, является ли
первое число квадратом второго.
a = 25, b = 5 => да
a = 2, b = 10 => нет
a = 9, b = -3 => да
a = -3, b = 9 => нет
*/

// string num1str = Console.ReadLine(); Получаем данные от пользователя, Console.ReadLine понимает только тип данных string
// int num1 = Convert.ToInt32(num1str); Конвертируем полученные данные в тип int

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()); // Объединили две строки выше
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго.");
}