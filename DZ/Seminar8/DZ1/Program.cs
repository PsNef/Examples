// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void sortMatrix(int[,] matrix)
{
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i,k])
                {
                    index = matrix[i, j];
                    matrix[i,j] = matrix [i,k];
                    matrix [i,k] = index;
                }
            }
        }
    }
}

//----------------------------------------------------------------------------------------------

int[,] matrix = NewMatrix(3, 4, -99, 99);
PrintMatrix(matrix);
System.Console.WriteLine();
sortMatrix(matrix);
PrintMatrix(matrix);