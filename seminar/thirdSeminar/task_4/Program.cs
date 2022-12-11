int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void PrintSqr(int number)
{
    number = number * number;
    Console.Write(number + ", ");
}
int count = 1;

int number = EnterData("Введите число: ");
while (count <= number)
{
    PrintSqr(count);
    count++;
}