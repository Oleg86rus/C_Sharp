//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int []  AddArray(int[] array)
{
    for(int count = 0; count < array.Length; count++)
    {
        Console.Write($"{count+1}-я ось: ");
        int ver = int.Parse(Console.ReadLine());
        array[count] = ver;
    }
    return array;
}

void FromFirstToSecond(int[] arr1, int [] arr2)
{
    double size = Math.Sqrt(Math.Pow(arr2[0]-arr1[0],2)+Math.Pow(arr2[1]-arr1[1],2)+Math.Pow(arr2[2]-arr1[2],2));
    Console.WriteLine(size);
}

int [] firstPoint = new int [3];
Console.WriteLine("Введите координаты первой точки: ")
firstPoint = AddArray(firstPoint);
int [] secondPoint = new int [3];
Console.WriteLine("Введите координаты второй точки: ")
secondPoint = AddArray(secondPoint);

FromFirstToSecond(firstPoint,secondPoint);