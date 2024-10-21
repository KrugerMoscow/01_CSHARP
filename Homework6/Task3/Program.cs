/* Задайте произвольную строку. Выясните,
является ли она палиндромом.
Пример:
“aBcD1ef!-” => Нет
“шалаш” => Да
“55655” => Да */

// Метод для проверки вводимой строки на палиндромность

bool InputStringIsPalindrome(string str)
{
    int index = str.Length - 1;

    for (int i = 0; i <= str.Length / 2; i++)
    {
        if (str[i] == str[index])
        {
            index--;
        }
        else
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Введите строку: ");
string input = Console.ReadLine();
bool result = InputStringIsPalindrome(input);
Console.Write(input + " => ");
Console.WriteLine(result ? "Да" : "Нет"); // тернарный оператор
