int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void findQuarter(int x, int y)
{
    if (x > 0 & y > 0) Console.WriteLine("Диапазон X от 0 до +бесконечности, диапазон Y от 0 до +бесконечности");
    if (x > 0 & y < 0) Console.WriteLine("Диапазон X от 0 до +бесконечности, диапазон Y от -бесконечности до 0");
    if (x < 0 & y < 0) Console.WriteLine("Диапазон X от от -бесконечности до 0, диапазон Y от от -бесконечности до 0");
    if (x < 0 & y > 0) Console.WriteLine("Диапазон X от от -бесконечности до 0, диапазон Y от 0 до +бесконечности");
}

int x = EnterData("Введите координаты X: ");
int y = EnterData("Введите координаты Y: ");
findQuarter(x, y);