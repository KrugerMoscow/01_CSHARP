/* Задача 2: Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер координатной четверти плоскости, 
в которой находится эта точка. */

Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Координата лежит в первой четверти.");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Координата лежит во второй четверти.");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Координата лежит в третьей четверти.");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Координата лежит в четвертой четверти.");
}
else
{
    Console.WriteLine("Координата лежит в нуле.");
}