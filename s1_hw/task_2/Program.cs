Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
    Console.WriteLine($"Наибольшее число: {firstNumber}");
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
    Console.WriteLine($"Наибольшее число: {secondNumber}");
else
    Console.WriteLine($"Наибольшее число: {thirdNumber}");