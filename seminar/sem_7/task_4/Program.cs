// Задайте двумерный массив размером m*n,
// Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


void PrintArray(int[,] arr) {
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write(arr[i, j] + " ");
            if (i == j) count += arr[i, j];
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма главной диагонали: {count}");
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
PrintArray(arr);