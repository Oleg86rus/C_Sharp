// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//
// 45 -> 101101
//
// 3 -> 11
//
// 2 -> 10

string number = "3";
int fromBase = 10;
int toBase = 2;

// string Binary(string num)
// {
//     int var = num;
//     string result = "";
//     while (var > 0)
//     {
//         result = $"{var % 2}" + result;
//         var = var / 2;
//     }
//     return result;
// }

string Binary(string num)
{
    return Convert.ToString(Convert.ToInt32(num, fromBase), toBase);
}

string triangle = Binary(number);
Console.WriteLine($"число {number} в 2 системе счисления: {triangle}");