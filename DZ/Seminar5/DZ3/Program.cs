// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] DoubleArray(int size = 5, int leftRange = 0, int rightRange = 20)
{
    double[] new_Array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < new_Array.Length; i++)
    {
        new_Array[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
    }
    return new_Array;
}

void MinMaxArray(double[] new_Array, out double min, out double max)
{
    min = 0;
    max = 0;

    for (int i = 0; i < new_Array.Length; i++)
    {
        if (max < new_Array[i])
        {
            max = new_Array[i];
        }
        if (min == 0 || min > new_Array[i])
        {
            min = new_Array[i];
        }
    }
}

void PrintArray(double[] ArrayForPrin)
{
    System.Console.WriteLine("[" + string.Join(", ", ArrayForPrin) + "]");
}

//------------------------------------------------------------------------------------------------------

double[] array = DoubleArray(6, 1, 5);

PrintArray(array);

MinMaxArray(array, out double minA, out double maxA);

System.Console.WriteLine($"Максимальное число в массиве: {maxA}");
System.Console.WriteLine($"Минимальное число в массиве: {minA}");

System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {maxA - minA}");