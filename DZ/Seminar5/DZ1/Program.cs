// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int Calculation(int [] new_Array)
{
    int sum = 0;
    for (int i = 0; i < new_Array.Length; i++)
    {
        if (new_Array[i] == new_Array[i] + new_Array[i] % 2)
        {
            sum++;
        }
    }
    return sum;
}   

void PrintArray(int[] ArrayForPrin)
{
    System.Console.WriteLine("[" + string.Join(", ", ArrayForPrin) + "]");
}

//------------------------------------------------------------------------------------------------------

int[] array = FillArray(10, 100, 999);

PrintArray(array);

int sum = Calculation(array);

System.Console.WriteLine(sum);