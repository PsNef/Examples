// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] ReadArray(string array)
{
    System.Console.WriteLine("Веведите числа b1, b2, k1, k2:");
    int[] readArray = Array.ConvertAll(System.Console.ReadLine()!.Split(", "), int.Parse);
    return readArray;
}

void Line(int[] new_Array, out int b1, out int b2, out int k1, out int k2)
{
    int b1 = readArray[0];
    int b2 = readArray[1];
    int k1 = readArray[2];
    int k2 = readArray[3];
}
//-----------------------------------------------------------------------------
int[] readArray = ReadArray("text");

Line(readArray, out int b1, out int b2, out int k1, out int k2);

int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;
int y2 = k2 * x + b2;
System.Console.WriteLine(y);
System.Console.WriteLine(y2);