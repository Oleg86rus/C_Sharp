﻿
int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindQuarter(int x, int y)
{
    int result = 0;
    if (x > 0 & y > 0) result = 1;
    if (x < 0 & y > 0) result = 2;
    if (x < 0 & y < 0) result = 3;
    if (x > 0 & y < 0) result = 4;
    return result;
}

int x = EnterData("Введите координаты X: ");
int y = EnterData("Введите координаты Y: ");

int number = FindQuarter(x, y);

Console.WriteLine("Ваши координаты находятся в " + number + " четверти");