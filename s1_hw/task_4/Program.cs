Console.WriteLine("Введите первое число: ");
int number = int.Parse(Console.ReadLine());
int count = 2;

while (count <= number)
{
    Console.Write($"{count}, ");
    count += 2;
}
