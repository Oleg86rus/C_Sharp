// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int initialNumber = new Random().Next(100, 1000);
int res = initialNumber / 100 * 10 + initialNumber % 10;
Console.WriteLine($"Случайное число {initialNumber}. Результат без второй цифры = {res}");