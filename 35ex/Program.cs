// Задача 35:
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] arr = new int[123];

void FillArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(0, 200);
    }
}

void PrintArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (i == 0) Console.Write($"[{mass[i]}, ");
        if (i == mass.Length - 1) Console.WriteLine($"{mass[i]}]");
        else Console.Write($"{mass[i]}, ");
    }
}

void FindCount(int[] mass)
{
    int i = 0;
    int count = 0;
    while (i < mass.Length)
    {
        if (mass[i] >= 10 && mass[i] <= 99)
        {
            count++;
        }
        i++;
    }
    Console.WriteLine($"{count} - столько значений содержатся в массиве, которые лежат в промежутке [10, 99]");
}

FillArr(arr);
PrintArr(arr);
Console.WriteLine();
FindCount(arr);