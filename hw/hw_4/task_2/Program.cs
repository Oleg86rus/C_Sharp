//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

void SumInNumb(string num)
{
    int result = 0;
    int number = 0;
    for(int i = 0; i < num.Length; i++)
    {
        result += int.Parse(num[i].ToString());
    }
    Console.WriteLine($"{num} -> {result}");
}

string EnterNumb(string text)
{
    Console.WriteLine(text);
    string result = Console.ReadLine();
    return result;
}

string numb = EnterNumb("Введите число и получите сумму его цифр: ");
SumInNumb(numb);