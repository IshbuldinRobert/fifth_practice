// Задача 33:
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] arr = new int[10];

Console.Write("Введите число от -9 до 9 включительно: ");
int num = Convert.ToInt32(Console.ReadLine());

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

void FindNum(int[] mass, int find_num)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] == find_num)
        {
            Console.WriteLine($"Введенное число есть в массиве под индексом {i}");
            break;
        }
    }
}

FillArr(arr);
PrintArr(arr);
Console.WriteLine("---------------------------------------");
FindNum(arr, num);