﻿// задача 4
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
 Console.Write ("Введите третье число");
 int c = Convert.ToInt32(Console.ReadLine());
 int max = a;



if (b > a)
max = b;
if (c > max)
max = c;



Console.WriteLine("{0} наибольшее число", max);
