
string[] CreateArray(string[] array) {
    for (int i = 0; i + 1 > 0 ; i++) {
        Console.Write("ВВедите строку, или нажмите Enter для завершения: ");
        string str = Console.ReadLine();
        if (str == "") break;
        else {
                Array.Resize(ref array, i+1);
                array[i] = str;
        }
    }
    return array;
}
string[] FilterArr(string[] arr) {
    string[] result = {};
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i].Length <= 3) {
            result = result.Concat(new string[] {arr[i]}).ToArray();
        }
    }
    return result;
}

string[] arr = {};
arr = CreateArray(arr);
string[] res = FilterArr(arr);
Console.WriteLine($"Результат: ['{string.Join("','", res)}']");