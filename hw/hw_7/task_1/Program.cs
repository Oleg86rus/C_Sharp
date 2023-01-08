// Задайте двумерный массив размером m*n,
// заполненный случайными вещественными числами

void PrintArray(double[,] arr) {
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

double[,] FillArr(int rows, int columns, int min, int max) {
    double[,] arr = new double[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            arr[i, j] = new Random().Next(min, max + 1)/10.0;
        }
    }
    return arr;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");

double[,] arr = FillArr(rows, columns, -100, 100);
PrintArray(arr);