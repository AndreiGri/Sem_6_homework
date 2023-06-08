﻿/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.

Если N = 5-> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

<aside>
❗️ Числа Фибоначчи — числовая ****последовательность,
каждый элемент которой равен сумме двух предыдущих. */

Console.Clear();                                                                 // Очищаем терминал

Console.Write("Введите число необходимых чисел Фибоначчи: ");                    // Запрашиваем число
int num = int.Parse(Console.ReadLine()!);                                        // Вводим число и записываем его в переменную
Console.Write(NumsFib(num));                                                     // Выводим в терминал результат вызывая метод NumsFib()

string NumsFib(int n)                                                            // Создаём метод NumsFib()
{
    string text;
    int j = 0;
    int k = 1;
    int []numsFib = new int[n];
    for(int i = 0; i < n; i++)                                                   // Перебором вставляем в массив numsFib[] числа Фибоначчи
    {
        numsFib[i] = j;
        if(numsFib[i] == 0)                                                      // Если число равно ноль то переменной j присваиваем 1 и записываем её в следующую ячейку массива
        {
            j = k;
        }
        else                                                                     // Иначе переменной k значение предыдущей ячейки, складываем со значением j и записываем в массив
        {
            k = numsFib[i - 1];
            j = j + k;
        }
    }
    return text = $"Ряд чисел Фибоначи будет: {String.Join(", ", numsFib)}";     // Возвращаем текст с результатом
}

