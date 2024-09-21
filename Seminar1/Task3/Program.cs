﻿// Начать следует F1 Restart OnmiSharp чтобы загрузился плагин C#

/* Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает
сумму первой и последней цифры этого числа.
456 => 10
782 => 9
918 => 17 */

Console.WriteLine("Ввидите трехзначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999) // визуально воспринимается проще, потому что сразу видно диапазон от 100 до 999
//if (num > 99 && num < 1000) // визуально воспринимается хуже, потому что надо подумать, хотя диапазон тот же от 100 до 999
{
    int firstDigit = num / 100; // 456/100=4.56, тк int может хранить только целый числа, то получим 4, дробная часть отпадет
    int lastDigit = num % 10; // 456%10=450+6, % означает остаток от деления, на 10 можно разделить только 450, а 6 останется и запишется в переменную
    int result = firstDigit + lastDigit;

    //Console.WriteLine("Сумму первой и последней цифры: " + result); // конкатенация
    Console.WriteLine($"Сумму первой и последней цифры: {result}"); // интерполяция
}
else
{
    Console.WriteLine("Ошибка ввода!");
}