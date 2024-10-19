/* Считать строку с консоли, содержащую латинские
буквы. Вывести на экран согласные буквы этой
строки.
Указание
Использовать рекурсию. Не использовать цикл.
Пример
“hello” => h l l
“World” => W r l d
“Hello world!” => H l l w r l d */

// Метод для проверки на буквы и на согласные с последующей печатью

void CheckPrintConsonants(string txt, int index)
{
    string vowels = "aeiouy";

    if (char.IsAsciiLetter(txt[index]) && !vowels.Contains(txt[index])) // ! - оператор отрицания
    {
        Console.Write($"{txt[index]}");
    }
}

// Метод с рекурсией, который проверяет не закончилась ли строка

void PrintConsonants(string txt, int index = 0) // int index = 0 опциональный параметр
{
    if (index == txt.Length)
    {
        return;
    }

    CheckPrintConsonants(txt, index);
    PrintConsonants(txt, index + 1);
}

Console.WriteLine("Введите строку, содержащую латинские буквы: ");
string text = Console.ReadLine();
PrintConsonants(text);