﻿/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

int user_number = new int();

Console.Write("Введите число ");
user_number = Convert.ToInt32(Console.ReadLine());

double result = (user_number/2);

if (result%2 == 0)

{
    Console.WriteLine("Ваше число чётное");
}

else
{
    Console.WriteLine("Ваше число нечётное");
}
