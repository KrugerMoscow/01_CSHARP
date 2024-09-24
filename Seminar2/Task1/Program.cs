/* Напишите программу, которая принимает на вход трёхзначное 
число и удаляет вторую цифру этого числа.
Примеры
a = 256 => 26
a = 891 => 81 */

Console.Write("Введите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999 || num <= -100 && num >= -999)
{
    int firstDigit = num / 100; // 256 / 100 = 2,56 , тк int целое число, то дробная часть отбрасывается
    int thirdDigit = num % 10; // 256 % 10 = 250 + 6, 6 это остаток от деления 256 на 10, 256/10=25,6

    int result = firstDigit * 10 + thirdDigit; // 2 * 10 + 6 = 26

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный ввод!");
}