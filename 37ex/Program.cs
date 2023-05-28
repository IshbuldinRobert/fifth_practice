// Задача 37:
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(0, 10);
    }
}

void PrintArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (i == 0) Console.Write($"[{mass[i]}, ");
        else if (i == mass.Length - 1) Console.WriteLine($"{mass[i]}]");
        else Console.Write($"{mass[i]}, ");
    }
}

Console.Write("Введите размер первого массива: ");
int len_1 = Convert.ToInt32(Console.ReadLine());
int len_2 = 0;

if (len_1 % 2 == 0) len_2 = len_1 / 2;
else len_2 = len_1 / 2 + 1;

int[] arr1 = new int[len_1];
int[] arr2 = new int[len_2];

FillArr(arr1);

void FindArr2FromArr1(int[] ar1, int[] ar2)
{
    if (ar1.Length % 2 == 0)
    {
        for (int i = 0; i < ar2.Length; i++)
        {
            ar2[i] = ar1[i] * ar1[(ar1.Length - 1) - i];
        }
    }
    else
    {
        for (int i = 0; i < ar2.Length; i++)
        {
            if (i == (ar1.Length - 1) - i)
            {
                ar2[i] = ar1[i];
            }
            else
            {
                ar2[i] = ar1[i] * ar1[(ar1.Length - 1) - i];
            }
        }
    }
}

FindArr2FromArr1(arr1, arr2);

Console.Write("Первый массив: ");
PrintArr(arr1);
Console.Write("Второй массив: ");
PrintArr(arr2);