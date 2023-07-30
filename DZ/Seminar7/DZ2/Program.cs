// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] NewMatrix(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void SearchMatrix(int[,] matrix, int number)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                sum = sum + 1;
                System.Console.WriteLine("Искомое число найдено: " + matrix[i, j]);
                break;
            }
        }
        System.Console.WriteLine();
        if (sum == 1)
        {
            break;
        }
    }
}

//---------------------------------------------------------------------------------------------
int number = ReadInt("Введите искомое число: ");

int[,] matrix = NewMatrix(5, 5, 1, 3);

PrintMatrix(matrix);

SearchMatrix(matrix, number);