﻿/* Напишите программу, которая выводит третью слева
цифру заданного числа или сообщает, что третьей
цифры нет.
456 => 6
7812 => 1
91 => Третьей цифры нет */

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 || num <= -100) // проверяем число состоит из трех и более цифр или нет, если нет, то программа идет на else
{
    while (num >= 1000 || num <= -1000) // В этом цикле получаем трехзначное число
    {
        num = num / 10; // делим на 10 до тех пор, пока не перестанет подходить под условие
    }

    int result = num % 10; // выводим остаок от деления на 10
    Console.WriteLine($"Третья цифра слева {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}