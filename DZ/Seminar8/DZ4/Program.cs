// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] NewMatrix(int row, int column, int column2, int min, int max)
{
    int[,,] newMatrix = new int[row, column, column2];
    Random rand = new Random();
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < newMatrix.GetLength(2); k++)
            {
                newMatrix[i, j, k] = rand.Next(min, max + 1);
            }
        }
    }
    return newMatrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]} ({i},{j},{k})\t");
            }
            System.Console.WriteLine();
        }
    }

}

void UniqueMatrix(int[,,] matrix)
{
    Random rand = new Random();
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < matrix.GetLength(2); k++)
            {
                if (matrix[i - 1, j - 1, k - 1] == matrix[i - 1, j - 1, k])
                {
                    matrix[i - 1, j - 1, k] = rand.Next(1, 10);
                    i = 0;
                }
                if (matrix[i - 1, j - 1, k - 1] == matrix[i - 1, j, k - 1])
                {
                    matrix[i - 1, j, k - 1] = rand.Next(1, 10);
                    i = 0;
                }
                if (matrix[i - 1, j - 1, k - 1] == matrix[i, j - 1, k - 1])
                {
                    matrix[i, j - 1, k - 1] = rand.Next(1, 10);
                    i = 0;
                }
                //-------------------------------------------------------------------
                if (matrix[i, j - 1, k - 1] == matrix[i - 1, j - 1, k])
                {
                    matrix[i - 1, j - 1, k] = rand.Next(1, 10);
                    i = 0;
                }
                if (matrix[i, j - 1, k - 1] == matrix[i - 1, j, k - 1])
                {
                    matrix[i - 1, j, k - 1] = rand.Next(1, 10);
                    i = 0;
                }
                if (matrix[i, j - 1, k - 1] == matrix[i, j - 1, k - 1])
                {
                    matrix[i, j - 1, k - 1] = rand.Next(1, 10);
                    i = 0;
                }
            }
        }
    }
}
//--------------------------------------------------------------------------------------------------------------


int[,,] matrix = NewMatrix(2, 2, 2, 1, 10);

PrintMatrix(matrix);

UniqueMatrix(matrix);

System.Console.WriteLine();

PrintMatrix(matrix);






// int[] array = new int[5];

// Random rand = new Random();

// int index = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(1, 6);
// }

// System.Console.WriteLine("[" + string.Join(", ", array) + "]");


// for (int i = 0; i < array.Length; i++)
// {
//     for (int j = 0; j < array.Length; j++)
//     {
//         if (i == j)
//         {
//             continue;
//         }
//         if (array [i] == array [j])
//         {
//             array[j] = rand.Next(1, 6);
//             i = 0;
//         }
//     }
// }

// System.Console.WriteLine("[" + string.Join(", ", array) + "]");

