﻿// Задача №1. Напишите программу, 
// которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Задача №3. Напишите программу, 
// которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница


Console.WriteLine("Введите число 1: ");

int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите квадрат числа: ");

int number2 = int.Parse(Console.ReadLine());
if (number2 == number1 * number1)
{
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Нет!");
}
