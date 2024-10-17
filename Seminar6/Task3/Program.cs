/* Считать строку с консоли, состоящую из латинских
букв в нижнем регистре. Выяснить, сколько среди
введённых букв гласных.
Пример
“hello” => 2
“world” => 1 */

/* int CountOfVowelLetters(string str)
{
    string vowelLetters = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowelLetters.Length; j++)
        {
            if (str[i] == vowelLetters[j])
            {
                count++;
            }
        }
    }
    return count;
} */

// Вариант 2:

int CountOfVowelLetters(string str)
{
    string vowelLetters = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (vowelLetters.Contains(str[i]))
        {
            count++;
        }

    }
    return count;
}

Console.Write("Введите исходное слово: ");
string inputStr = Console.ReadLine();

int result = CountOfVowelLetters(inputStr);
Console.Write($"В '{inputStr}' гласных букв: {result}");
