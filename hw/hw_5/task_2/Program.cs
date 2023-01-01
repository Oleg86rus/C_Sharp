// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
int OddCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            count += arr[i];
    }
    return count;
}

int[] arr = CreateMassive(5, -9, 9);
int result = OddCount(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"Сумма чисел на нечётных позициях в массиве: {result}");