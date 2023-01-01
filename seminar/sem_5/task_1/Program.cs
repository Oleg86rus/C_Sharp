

int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
int SumNumbers(int[] arr, bool simbol)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
           sumPos += arr[i];
        }
        else
        {
            sumNeg += arr[i];
        }
    }
    if (simbol)
        return sumPos;
    else
        return sumNeg;
}

int[] arr = CreateMassive(12, -9, 9);
int sumPos = SumNumbers(arr, true);
int sumNeg = SumNumbers(arr, false);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"Сумма положительных чисел равна {sumPos}. Сумма отрицательных чисел равна {sumNeg}");