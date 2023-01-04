﻿// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника:
// ** каждая сторона треугольника меньше суммы двух других сторон

string CorrectTriangle(int a, int b, int  c)
{
    if (a < (b + c) && b < (a + c) && c < (a + b)) return "cуществует";
    else return "не существует";
}

string triangle = CorrectTriangle(2, 2, 2);
Console.WriteLine($"Треугольник {triangle}");