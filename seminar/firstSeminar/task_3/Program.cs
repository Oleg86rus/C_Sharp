Console.WriteLine("Введите число: ");
int firstNumber = int.Parse(Console.ReadLine());
string [] days: {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int dayIndex = days[firstNumber - 1];

Console.WriteLine(dayIndex);