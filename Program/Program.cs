// string[] array = {"hello", "2", "world", ":-)"};
string[] array = {"1234", "1567", "-2", "computer science"};
// string[] array = {"Russia", "Denmark", "Kazan"};

Console.WriteLine("Исходный массив:");
PrintArray(array);
int sizeNew = CountStr3(array);

string[] arrayNew = CreateArrayOf3(array, sizeNew);
Console.WriteLine("Массив из элементов, длина которых меньше или равна 3:");
PrintArray(arrayNew);

int CountStr3(string[] arr)
{
    int count3 = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3)
            count3++;
    return count3;
}

string[] CreateArrayOf3(string[] arr, int size)
{
    string[] newArr = new string[size];
    int indexNewArr = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3)
        {
            newArr[indexNewArr] = arr[i];
            indexNewArr++;
        }
    return newArr;
}

void PrintArray(string[] arr)
{
    Console.Write($"[");
    if (arr.Length != 0)
        Console.Write($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
        Console.Write($", {arr[i]}");
    Console.WriteLine("]");
}
