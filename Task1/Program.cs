﻿ /*
 Пользователь вводит с клавиатуры M чисел. 
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())
1. Ввод чисел
2. Разбиваем сплитом
3. Если >0 то count++
4. Выводим количество чисел больше 0
*/
Console.Write("Введите числа через запятую: ");
string[] numbers = Console.ReadLine()!.Split(',');
int count = 0;
 foreach (var item in numbers)
{
    if (int.Parse(item) > 0) 
    {
        count++;
    }
}
Console.Write($" -> {count}");