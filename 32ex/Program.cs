// Задача 32:
// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] arr = new int[10];

void FillArr(int[] fmass)
{
    for (int i = 0; i < fmass.Length; i++)
    {
        fmass[i] = new Random().Next(-9, 10);
    }
}

void PrintArr(int[] pmass)
{
    for (int i = 0; i < pmass.Length; i++)
    {
        if (i == pmass.Length - 1) Console.WriteLine($"{pmass[i]}]");
        else if (i == 0) Console.Write($"[{pmass[i]}, ");
        else Console.Write($"{pmass[i]}, ");
    }
}

void ReverseArr(int[] rmass)
{
    for (int i = 0; i < rmass.Length; i++)
    {
        rmass[i] = rmass[i] * (-1);
    }
}

FillArr(arr);
PrintArr(arr);
ReverseArr(arr);
Console.WriteLine("---------------------------------------");
Console.WriteLine($"Массив с обратными по знаку элементами: ");
PrintArr(arr);