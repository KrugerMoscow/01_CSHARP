/* Напишите программу, которая будет принимать на вход два
числа и выводить, является ли первое число кратным второму.
Если первое число не кратно второму, то программа выводит
остаток от деления.
Примеры
14, 5 => нет, 4
16, 8 => да
4, 3 => нет, 1 */

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

int result = firstDigit % secondDigit;

if ( result == 0)
{
    Console.WriteLine("Да");
    
}
else
{
    Console.WriteLine($"Нет, {result}");
}