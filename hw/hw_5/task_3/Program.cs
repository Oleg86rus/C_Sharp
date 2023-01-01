// Зайдайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.

int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
int Diff(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }
    int res = max - min;
    return res;
}

int[] arr = CreateMassive(5, 0, 9);
int result = Diff(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"max - min: {result}");