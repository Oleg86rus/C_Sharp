// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void PrintArray(int[,] arr, int col) {
    double[] res = new double[col];
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write(arr[i, j] + " ");
            res[j] += arr[i, j];
        }
        Console.WriteLine();
    }
    for (int i = 0; i < res.GetLength(0); i++) {
        res[i] /= arr.GetLength(0);
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: [{string.Join("; ", res)}]");
//     Console.WriteLine($"{string.Join("; ", res)}");
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
            arr[i, j] = i + j;
        }
    }
    return arr;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");

int[,] arr = FillArr(rows, columns, -100, 100);
PrintArray(arr, columns);