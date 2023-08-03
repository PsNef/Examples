// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] NewMatrix(int row, int column, int min, int max)
{
    int[,] newMatrix = new int[row, column];
    for (int k = 1, i = 0, j = 0, t = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i < newMatrix.GetLength(0) - 1 && t == 0)
        {
            newMatrix[j, i] = k;
            k++;
        }
        if (i == newMatrix.GetLength(0) - 1 && t == 0)
        {
            newMatrix[j, i] = k;
            j++;
            k++;
            i--;
        }
        if (j == newMatrix.GetLength(0) - 1 && t == 0)
        {
            t++;
            i = 0;
        }
        //--------------------------------------------------------------------------------------------1
        if (i < newMatrix.GetLength(0) - 1 && t == 1)
        {
            newMatrix[j, newMatrix.GetLength(0) - 1 - i] = k;
            k++;
        }
        if (i == newMatrix.GetLength(0) - 1 && t == 1)
        {
            newMatrix[j, newMatrix.GetLength(0) - 1 - i] = k;
            k++;
            i--;
            j--;
            System.Console.WriteLine(j);
        }
        if (j == newMatrix.GetLength(0) - (newMatrix.GetLength(0)-1) && t == 1)
        {
            t++;
            i = 0;
        }
        //--------------------------------------------------------------------------------------------2
        if (i < newMatrix.GetLength(0) - 2 && t == 2)
        {
            newMatrix[j, i] = k;
            k++;
        }
        if (i == newMatrix.GetLength(0) - 2 && t == 2)
        {
            newMatrix[j, i] = k;
            j++;
            k++;
            i--;
        }
        if (j == newMatrix.GetLength(0) - 2 && t == 2)
        {
            t++;
            i = 0;
        }
        //--------------------------------------------------------------------------------------------3
        if (i < newMatrix.GetLength(0) - 2 && t == 3)
        {
            newMatrix[j, newMatrix.GetLength(0) - 2 - i] = k;
            k++;
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
//----------------------------------------------------------------------------------------

int[,] matrix = NewMatrix(4, 4, 1, 4);
PrintMatrix(matrix);