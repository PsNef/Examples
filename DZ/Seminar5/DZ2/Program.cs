// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size = 5, int leftRange = 0, int rightRange = 20)
{
    int[] new_Array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < new_Array.Length; i++)
    {
        new_Array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return new_Array;
}

int Calculation(int[] new_Array)
{
    int sum = 0;
    for (int i = 0; i < new_Array.Length; i++)
    {
        if (i < i + i % 2)
        {
            sum += new_Array[i];
        }
    }
    return sum;
}

void PrintArray(int[] ArrayForPrin)
{
    System.Console.WriteLine("[" + string.Join(", ", ArrayForPrin) + "]");
}

//------------------------------------------------------------------------------------------------------

int[] array = FillArray(6, 1, 5);

PrintArray(array);

int sum = Calculation(array);

System.Console.WriteLine(sum);