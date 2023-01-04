// 1[1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

int[] CreateMassive(int count, int min, int max)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ReverseMyArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int j = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = j;
    }
}

int[] array = CreateMassive(7, 1, 20);
Console.WriteLine(String.Join(" ", array));
ReverseMyArray(array);
Console.WriteLine(String.Join(" ", array));