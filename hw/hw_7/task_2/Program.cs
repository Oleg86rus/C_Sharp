// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
//
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//
// 17 -> такого числа в массиве нет


void PrintArray(int[,] arr, int row, int col) {
    int res = 0;
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write(arr[i, j] + " ");
            if (i == row && j == col) res = arr[i, j];
        }
        Console.WriteLine();
    }
    if (res != 0) Console.WriteLine($"Числ с позицией {row}, {col}: {res}");
    else  Console.WriteLine($"Числа с позицией {row}, {col} в массиве нет");
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
int findingRow = 3;
int findingCol = 2;

int[,] arr = FillArr(rows, columns, -100, 100);
PrintArray(arr, findingRow, findingCol);