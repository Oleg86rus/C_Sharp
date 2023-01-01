// задайте одномерный массив из 123 случайных чисел.
// найдите количество элементов массива,
// значения которых лежат в отрезке [10, 99]


int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int NumberFind(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            count++;
    }
    return count;
}

int[] arr = CreateMassive(123, -999, 999);
int findNumber = NumberFind(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"Количество элементов в массиве: {findNumber}");