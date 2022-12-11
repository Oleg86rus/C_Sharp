//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void CubeNumber(int number)
{
    number = number * number * number;
    Console.Write(number + ", ");
}
int count = 1;

int number = EnterData("Введите число: ");
while (count <= number)
{
    CubeNumber(count);
    count++;
}