// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum (int M, int N)
{
    if (M == 0)return N + 1;
    if (M !=0 && N == 0)return Sum (M - 1, 1);
    if (M > 0 && N > 0) return Sum(M - 1, Sum(M, N - 1));
    return Sum(M, N);
}

//-----------------------------------------------------------------------------------------------

int M = ReadInt("Введите число:");

int N = ReadInt("Введите число:");

int sum = Sum(M, N);

System.Console.WriteLine($"Cумма всех чисел равна: {sum}");