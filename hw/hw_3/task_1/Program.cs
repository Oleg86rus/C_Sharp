//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
string AddString(string str)
{
    Console.Write($"Введите число: ");
    string ver = Console.ReadLine();
    return ver;
}
void IsPalindrom(string str)
{
    string pall = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        pall += str[i];
    }
    if (str == pall) Console.WriteLine("Число является палиндромом!");
    else Console.WriteLine("Число не является палиндромом!");
}
string number = AddString("Введите число: ");
IsPalindrom(number);