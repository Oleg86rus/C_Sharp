// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве


int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
int[] Multiplication(int[] arr)
{
    int[] res = new int[arr.Length/2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        res[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return res;
}

int[] arr = CreateMassive(5, -9, 9);
int[] result = Multiplication(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"Новый массив: [{string.Join(",", result)}]");