// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int[] CopyArr(int[] arr) {
    int[] res = new int[arr.Length];
    for (int i = 0; i < res.Length; i++) {
        res[i] = arr[i];
    }
    return res;
}

int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int[] arr = CreateMassive(5, 100, 999);
int[] copy = CopyArr(arr);
Console.WriteLine($"{string.Join(" ", arr)}");
Console.WriteLine($"{string.Join(" ", copy)}");