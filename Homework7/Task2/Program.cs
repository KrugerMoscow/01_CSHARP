/* Задача 2: Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n.
Пример
m = 2, n = 3 -> A(m,n) = 29 */

// Метод для вычисления фукции Аккермана
// Псевдокод из википедии

//using Internal;

int GetFunAckerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return GetFunAckerman(n - 1, 1);
    }
    else
    {
        return GetFunAckerman(n - 1, GetFunAckerman(n, m - 1));
    }
}

// Основаная программа

int numN = 3;
int numM = 5;

int result = GetFunAckerman(numN, numM);
Console.WriteLine(result);