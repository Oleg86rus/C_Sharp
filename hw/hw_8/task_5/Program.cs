// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            if (array[i, j]< 10){Console.Write($"0{array[i, j]} ");}
            else {Console.Write($"{array[i, j]} ");}
        }
        Console.WriteLine("");
    }
}

int[,] Spiral(int[,] array) {
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int count = 1;
    for (int i = 0, j = 0, k = 0; row != 0; i++,j++) {
        for (k = 0; k < col - 1; k++) {array[i, j++] = count++;}
        for (k = 0; k < row - 1; k++) {array[i++, j] = count++;}
        for (k = 0; k < col - 1; k++) {array[i, j--] = count++;}
        for (k = 0; k < row - 1; k++) {array[i--, j] = count++;}
        row = row < 2 ? 0 : row - 2;
        col = col < 2 ? 0 : col - 2;
    }

    return array;
}

int[,] array = new int [4,4];
array = Spiral(array);
PrintArray(array);