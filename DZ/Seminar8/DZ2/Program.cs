// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] NewMatrix(int row, int column, int min, int max)
{
    int[,] newMatrix = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return newMatrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }

}

int SumMatrix(int[,] matrix)
{
   
    int sum2 = 0;
    int index = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum1 = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum1 += matrix[i,j];
        }

        if (sum2 > sum1 || sum2 == 0)
        {
            sum2 = sum1;
            index = i + 1;
        }
    }
    return index;
}
//-----------------------------------------------------------------------------------------------
int[,] matrix = NewMatrix(3, 3, 1, 4);
PrintMatrix(matrix);
System.Console.WriteLine();
int index = SumMatrix(matrix);
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {index} строка");