Console.Write("Введите размер массива: ");
var str = Console.ReadLine() ?? "";

if (!int.TryParse(str, out var value) || value < 1)
{
    Console.Error.WriteLine($"{str} не является числом, либо задан размер массива меньше одного элемента");
    return;
}

float[] arr = new float[value];
Random rnd = new();

for (int i = 0; i < value; i++)
    arr[i] = (float)(rnd.Next(0, 100) + rnd.NextDouble()); // пусть для наглядности будут такими

float maxVal = arr[0];
float minVal = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > maxVal) maxVal = arr[i];
    if (arr[i] < minVal) minVal = arr[i];
}

Console.WriteLine("В массиве вещественных чисел:");
for (int i = 0; i < arr.Length; i++)
    Console.WriteLine(arr[i].ToString());
Console.WriteLine($"максимальное число: {maxVal}");
Console.WriteLine($"минимальное число: {minVal}");
Console.WriteLine($"разница между максимальным и минимальными элементами: {maxVal - minVal}");
