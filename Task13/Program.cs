﻿Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100)
{
while  (a > 999)
  a = a / 10;
Console.WriteLine(a % 10);
}
if (a < 100)
Console.WriteLine("третьей цифры нет");

