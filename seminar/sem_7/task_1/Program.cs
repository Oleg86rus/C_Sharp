// Задайте двумерный массив размером m*n, заполненный случайными целыми числами

// m=3 n = 4
// 1 3 8 19
// 5 -2 33 -2
// 77 3 8 1

void PrintArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
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
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");

int[,] arr = FillArr(rows, columns, 0, 10);
PrintArray(arr);