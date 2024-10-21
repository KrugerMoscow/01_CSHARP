/* Задача 2: Задайте строку, содержащую латинские буквы
в обоих регистрах. Сформируйте строку, в которой все
заглавные буквы заменены на строчные.
Пример
“aBcD1ef!-” => “abcd1ef!-” */


string GetLowerLattersFromUpper(string str)
{
    string lowercaseString = string.Empty;

    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsUpper(str[i])) // Проверка на заглавные буквы
        {
            lowercaseString += char.ToLower(str[i]); // Изменение заглавных на строчные
        }
        else
        {
            lowercaseString += str[i];
        }
    }
    return lowercaseString;
}

Console.WriteLine("Введите строку: ");
string input = Console.ReadLine();
string result = GetLowerLattersFromUpper(input);
//string result = input.ToLower(); // Ну или вместо отдельного метода, использовать эту строчку
Console.WriteLine(result);
