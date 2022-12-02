Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Наибольшее число: {firstNumber}");
    Console.WriteLine($"Наименьшее число: {secondNumber}");
}
else
{
    Console.WriteLine($"Наибольшее число: {secondNumber}");
    Console.WriteLine($"Наименьшее число: {firstNumber}");
}