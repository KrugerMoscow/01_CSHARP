/* Задание 1
Определите, делится ли число на другое
Описание: Напишите метод, который на вход принимает два целых числа и проверяет,
делится ли первое число на второе. Если делится, выводите "делится", иначе
выводите "не делится".
Пример использования: На входе:
● firstNumber: 10
● secondNumber: 2
На выходе:
● делится
На входе:
● firstNumber: 10
● secondNumber: 3
На выходе:
● не делится */

Console.Write("Введите первое целое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (secondNum == 0)
{
    Console.WriteLine("На 0 делить нельзя.");
}

else if (firstNum % secondNum == 0)
{
    Console.WriteLine($"{firstNum} делится на {secondNum} без остатка.");
}

else
{
    Console.WriteLine($"{firstNum} не делится на {secondNum} без остатка.");
}