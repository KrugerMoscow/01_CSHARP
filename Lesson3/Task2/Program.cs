void PrintSquares(int limit) //функция ничего не возвращает, поэтому void, вывод в консоль - побочный эффект
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}

// Вызов функции

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);