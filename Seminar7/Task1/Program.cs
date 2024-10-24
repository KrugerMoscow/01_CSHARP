﻿/* Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от 1 до N.
Указание
Использовать рекурсию. Не использовать цикл.
Пример
N=5 => 1 2 3 4 5 */


void PrintNaturalNumbers(int num)
{
    if(num == 0)
    {
        return; // Возврат к последнему сохраненному в стеке значению параметра, не выход из функции,
                // после этого выполняются инструкции, которые еще не были выполнены (переход к Console.Write($"{num} ");)
                // значения в Console.Write($"{num}" берутся из стека, начиная с последнего сохраненного значения
    }
    PrintNaturalNumbers(num-1);
    Console.Write($"{num} ");
                // Если Console.Write($"{num}") будет стоять перед рекурсией, то данные из стека не используются в выводе 
                // и поэтому в консоль порядок вывода значений будет как при обычном цикле
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(number);