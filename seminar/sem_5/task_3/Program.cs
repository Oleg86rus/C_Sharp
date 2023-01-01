// Напишите программу, которая определяет,
// присутствует ли заданное число в массиве



int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
string NumberFind(int[] arr, int number)
{
    bool symbol = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        symbol = true;
    }
    if (symbol)
        return "Да";
    else
        return "Нет";
}

int[] arr = CreateMassive(12, -999, 999);
int number = 4;
string findNumber = NumberFind(arr, number);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"Наличие числа {number} в массиве: {findNumber}");