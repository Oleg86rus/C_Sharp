// Задайте двумерный массив размером m*n,
// найдите элементы, у которых оба индекса чётные и замените на их квадраты


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
            if (i % 2 == 0 && j % 2 == 0) arr[i, j] = i*i + j*j;
            else arr[i, j] = i + j;
        }
    }
    return arr;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");

int[,] arr = FillArr(rows, columns, -100, 100);
PrintArray(arr);