// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] ReadArray(string array)
{
    System.Console.WriteLine("Веведите числа, например: 1, 2, -3:");
    int[] readArray = Array.ConvertAll(System.Console.ReadLine()!.Split(", "), int.Parse);
    return readArray;
}

void PrintArray(int[] ArrayForPrin)
{
    System.Console.WriteLine("[" + string.Join(", ", ArrayForPrin) + "]");
}


int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}
//---------------------------------------------------------------------------------------------------------

int[] readArray = ReadArray("text");
int sum  = SumArray(readArray);
PrintArray(readArray);
System.Console.WriteLine($"Количество чисел в массиве больше нуля:----->{sum}");