/* Задание 2
Поиск среднего из трех чисел
Описание: Напишите метод, который принимает на вход три числа и возвращает
среднее из этих чисел (то есть не самое большое и не самое маленькое).
Пример использования: На входе:
● a: 5
● b: 3
● c: 8
На выходе:
● 5
На входе:
● a: 1
● b: 9
● c: 7
На выходе:
● 7 */

Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondtNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

if (firstNum >= secondtNum && firstNum <= thirdNum || firstNum >= thirdNum && firstNum <= secondtNum) // c>a>b || b>a>c
{
    Console.WriteLine(firstNum);
}
else if (secondtNum >= firstNum && secondtNum <= thirdNum || secondtNum >= thirdNum && secondtNum <= firstNum) // c>b>a || a>b>c
{
    Console.WriteLine(secondtNum);
}
else
{
    Console.WriteLine(thirdNum);
}