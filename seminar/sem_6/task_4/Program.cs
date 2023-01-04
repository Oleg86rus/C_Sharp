// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
//
// Если N = 5 -> 0 1 1 2 3
//
// Если N = 3 -> 0 1 1
//
// Если N = 7 -> 0 1 1 2 3 5 8
//
// ❗ **Числа Фибоначчи** — числовая ****последовательность,
// каждый элемент которой равен сумме двух предыдущих.

int[] Fibo(int[] arr)
{
    arr[0] = 0;
    arr[1] = 1;
    int count = 2;
    while (count < arr.Length)
    {
        arr[count] = arr[count - 1] + arr[count - 2];
        count++;
    }
    return arr;
}
int num = 7;
int[] fibo = new int[num];
int[] res = Fibo(fibo);
Console.WriteLine($"{string.Join(" ", res)}");
