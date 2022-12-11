//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void Exponentiation(int number, int exponent)
{
    double result = Math.Pow(number, exponent);
    Console.WriteLine($"{number} в степени {exponent} = {result}");
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = EnterData("Введите число ");
int exponent = EnterData("В какую степень возвести число? ");
Exponentiation(number,exponent);