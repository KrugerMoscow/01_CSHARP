/* Задача 1.
Вычислить значение формулы (a*b)/(c+d),
где a,b,c,d - некоторые целые числа. 
Решение оформить в виде функции. */

double CalculateFormula(int a, int b, int c, int d) //значения в скобках называются параметры
{
    double numenator = a * b; //числитель
    int denomenator = c + d; //знаменатель
    double result = numenator / denomenator; // возвращаемое значение должно быть такого же типа, как функция
    return result;
}

// Запуск функции
//CalculateFormula(); - запуск функции без входных параметров
double result = CalculateFormula(1, 2, 3, 4); // цифры в скобках называются аргумент, тип данных переменной, куда выводится функция должен совпадать с типом данных функции
Console.WriteLine(result);
