// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
int EvenCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
}

int[] arr = CreateMassive(5, 100, 999);
int result = EvenCount(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"Количество четных чисел в массиве: {result}");