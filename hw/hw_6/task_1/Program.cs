// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// 0, 7, 8, -2, -2 -> 2
//
// 1, -7, 567, 89, 223-> 3

void PositiveCounter(int[] array) {
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result++;
    }
    Console.Write($"[{string.Join(",", array)}] -> ");
    Console.WriteLine(result);
}

int[] CreateArray(int[] array) {
    int [] result = {};
    for (int i = 0; i + 1 > 0 ; i++) {
        Console.Write("ВВедите число, или нажмите Enter для завершения: ");
        string str = Console.ReadLine();
        int var = 0;
        if (str == "") break;
        else {
                Array.Resize(ref array, i+1);
                var = Int32.Parse(str);
                array[i] = var;
        }
    }
    return array;
}

int[] array = {};
array = CreateArray(array);
PositiveCounter(array);