/* Напишите программу, которая принимает на вход трёхзначное
число и возводит вторую цифру этого числа в степень, равную
третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1 */

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999) // для положительного числа
{
    int secondDigit = num / 10 % 10; // 487 / 10 = 48 (тк int дробная часть отбрасывается) % 10 = 4.8 ( % это остаток от деления, те 8)
    int thirdDigit = num % 10; // 487 % 10 = 48.7 (получаем остаток от деления, те 7)

    int result = secondDigit;
    /*
    Вариант 1: 
    int count = 1; // Щетчик

    while (count < thirdDigit) // не <= потому что result уже содержит одно значение
    {
        result *= secondDigit; // result = result * secondDigit
        count++;
    }
    */

    // Вариант 2:
    for (int i = 1; i < thirdDigit; i++)
    {
        result *= secondDigit; // result = result * secondDigit
    }

    Console.WriteLine(result);
}

else if (num <= -100 && num >= -999) // для отрицательного числа
{
    int secondDigit = num / 10 % 10; // 487 / 10 = 48 (тк int дробная часть отбрасывается) % 10 = 4.8 ( % это остаток от деления, те 8)
    int thirdDigit = num % 10; // 487 % 10 = 48.7 (получаем остаток от деления, те 7)

    int result = secondDigit;
    /*
    Вариант 1: 
    int count =-1; // Щетчик

    while (count > thirdDigit) // не >= потому что result уже содержит одно значение
    {
        result *= secondDigit; // result = result * secondDigit
        count--;
    }
    */

    // Вариант 2:
    for (int i = -1; i > thirdDigit; i--)
    {
        result *= secondDigit; // result = result * secondDigit
    }

    Console.WriteLine(result);
}

else
{
    Console.WriteLine("Ошибка ввода!");
}
