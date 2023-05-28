// Задача 31:
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] arr = new int[12];

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

int NegativeElementArr(int[] nmass)
{
    int i = 0;
    int sumNegElement = 0;
    while (i < nmass.Length)
    {
        if (nmass[i] < 0)
        {
            sumNegElement = sumNegElement + nmass[i];
        }
        i++;
    }
    return sumNegElement;
}

int PositiveElementArr(int[] pmass)
{
    int i = 0;
    int sumPosElement = 0;
    while (i < pmass.Length)
    {
        if (pmass[i] > 0)
        {
            sumPosElement = sumPosElement + pmass[i];
        }
        i++;
    }
    return sumPosElement;
}

FillArr(arr);
PrintArr(arr);
Console.WriteLine("---------------------------------------");
Console.WriteLine($"Сумма отрицательных членов массива: {NegativeElementArr(arr)}");
Console.WriteLine($"Сумма отрицательных членов массива: {PositiveElementArr(arr)}");