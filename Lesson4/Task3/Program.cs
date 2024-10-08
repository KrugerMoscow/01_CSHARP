/* Задача 3.
Считать с консоли строку, состоящую из цифр
и латинских букв.
Сформировать новую строку, 
состоящую из букв исходной строки. */

// Метод для создания строк

string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if(char.IsAsciiLetter(e) == true) // метод определяет является ли перменная e буквой в таблице символов ASCII
        {
            letters = letters + e;
        }
    }
    return letters;
}

// вызов метода

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);