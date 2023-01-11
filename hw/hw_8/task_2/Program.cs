// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void PrintArray(int[,] arr, int rows) {
    int[] res = new int[rows];
    int count = 0;
    int rowMin = 0;
    for (int i = 0; i < arr.GetLength(0); i++) {
        count = 0;
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write(arr[i, j] + " ");
            count += arr[i, j];
        }
        Console.WriteLine();
        res[i] = count;
    }
    Console.WriteLine();

    for (int i = 0; i < res.GetLength(0) - 1; i++) {
        if (res[i] < res[i + 1]) rowMin = i;
        else rowMin = i + 1;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {rowMin}");
}

int EnterData(string str) {
    Console.WriteLine(str);
    int res = int.Parse(Console.ReadLine());
    return res;
}

int[,] FillArr(int rows, int columns, int min, int max) {
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");

int[,] arr = FillArr(rows, columns, -100, 100);
PrintArray(arr, rows);
