// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// 4->24
// 5->120


int GetNumbers(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int NumbersCount(int num)
{
    int count = 1;
    while (num > 0)
    {
        count *= num;
        num--;
    }
    return count;
}

int num = GetNumbers("Введите число: ");
int count = NumbersCount(num);
Console.WriteLine($"Произведение чисел: {count}");