﻿/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine("Укажите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное значение  ");
int max = a;
if (max < b) max = b;
Console.WriteLine (max);
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.WriteLine("Укажите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число 3");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное значение  ");

int max = a;
if (max < b) max = b;
if (max < c) max = c;

Console.WriteLine (max);
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет


Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");
*/


/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа до N");
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
Console.Write(i + ", ");
}
*/
