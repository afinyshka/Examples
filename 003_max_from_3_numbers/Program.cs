﻿Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int c = int.Parse(Console.ReadLine());
int max = a;

if (max<b)
{
    max=b;
}
if (max<c)
{
    max=c;
}
Console.Write("max: ");
Console.WriteLine(max);