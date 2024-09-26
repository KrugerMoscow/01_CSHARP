/* Задача 3: Напишите программу, которая принимает 
на вход целое число из отрезка [10, 99] и 
показывает наибольшую цифру числа. */

Console.Write("Введите число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    
    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"Большая цифра в числе {num} - {firstDigit}");
    }
    else
    {
        Console.WriteLine($"Большая цифра в числе {num} - {secondDigit}");
    }
}
else
{
    Console.WriteLine("Число не входит в диапазон чисел от 10 до 99");
}