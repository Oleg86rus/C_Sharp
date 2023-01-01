// принять число
// написать метод, где в цикле находим сумму чисел
// вывод результата

int SumOfNumbers(int num)
{
    int summ = 0;
    for (int count = 1; count <= num; count++)
    {
        summ += count;
    }
    return summ;
}

int GetNumbers(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int num = GetNumbers("Введите число: ");
int summ = SumOfNumbers(num);
Console.WriteLine($"Полученная сумма: {summ}");