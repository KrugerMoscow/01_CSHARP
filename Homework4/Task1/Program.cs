/* Задача 1: Напишите программу, которая бесконечно
запрашивает целые числа с консоли. Программа
завершается при вводе символа ‘q’ или при вводе
числа, сумма цифр которого четная.
Пример
5 12 16 q [STOP]
3 45 342 15 [STOP] */


// Метод для проверки введена ли 'q'

bool StringOrDigit(string input)
{
    if (input == "q")
    {
        Console.WriteLine("Вы завершили программу!");
        return true;
    }
    else
    {
        return false;
    }
}

// Метод для опредления суммы цифр в числе и четности этой суммы

bool GetSumOfDigit(int number)
{
    int newNumber = number; // Пересохраяем исходное число, чтобы оно не менялось в процессе работы циклов
    int sum = 0;

    while (newNumber % 10 != 0) // цикл считает сумму цифр в числе
    {
        //Console.WriteLine(newNumber); // Добавил для наглядности
        sum = sum + newNumber % 10;
        newNumber /= 10;
        //Console.WriteLine(newNumber + " " + sum); // Добавил для наглядности
    }

    if (sum % 2 == 0) // проверка на четность суммы
    {
        Console.WriteLine($"Сумма цифр в числе {number} четная ({sum}). Вы завершири программу!");
        return true;
    }
    else
    {
        return false;
    }
}

// Начало программы

while (true) // бесконечный цикл
{
    Console.Write("Для выхода нажмите 'q' или введите целое число: ");
    string answer = Console.ReadLine();

    bool answerQ = StringOrDigit(answer);

    if (answerQ == true)
    {
        break;
    }

    else
    {
        int answerNum = Convert.ToInt32(answer);
        bool sumOfDigit = GetSumOfDigit(answerNum);

        if (sumOfDigit == true)
        {
            break;
        }

    }
}











