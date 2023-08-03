// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
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

void MatrixMultiplication(int[,] Matrix_1, int[,] Matrix_2, int[,] Matrix_3)
{

    for (int i = 0; i < Matrix_1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix_1.GetLength(0); j++)
        {
            for (int k = 0; k < Matrix_1.GetLength(1); k++)
            {
                Matrix_3[i, j] += Matrix_1 [i,k] * Matrix_2 [k,j];
            }
        }
    }
}
//---------------------------------------------------------------------------------------------------------------
int matrix1_Row = ReadInt("Для перемножения матриц, введите колличество строк в матрице");
int matrix1_Colum = ReadInt("Для перемножения матриц, введите колличество столбцов в матрице");

int[,] matrix_1 = NewMatrix(matrix1_Row, matrix1_Colum, 1, 10);

int[,] matrix_2 = NewMatrix(matrix1_Colum, matrix1_Row, 1, 10);

int[,] matrix_3 = new int [matrix1_Row, matrix1_Row];

System.Console.WriteLine("Матрица 1:");
System.Console.WriteLine();
PrintMatrix(matrix_1);
System.Console.WriteLine("Матрица 2:");
System.Console.WriteLine();
PrintMatrix(matrix_2);

MatrixMultiplication(matrix_1, matrix_2, matrix_3);
System.Console.WriteLine("Результат переремножения:");
System.Console.WriteLine();
PrintMatrix(matrix_3);