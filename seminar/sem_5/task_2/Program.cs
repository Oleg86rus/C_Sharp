// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные и наоборот


int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
int[] ArrRevert(int[] arr)
{
    int[] array = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = arr[i] * -1;
    }
    return array;
}

int[] arr = CreateMassive(12, -9, 9);
int[] revertArr = ArrRevert(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"Инвертированный массив: [{string.Join(",", revertArr)}]");