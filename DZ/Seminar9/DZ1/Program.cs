// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum (int M, int N)
{
    if (M > N)return 0;

    return N + Sum(M, N - 1);
}
//-----------------------------------------------------------------------------------------------

int M = ReadInt("Введите число:");

int N = ReadInt("Введите число:");

int sum = Sum(M, N);

System.Console.WriteLine($"Cумма всех чисел равна: {sum}");