// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Readint (string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());  
}
int Result(int A, int B)
{
    int index = 0;
    int result = 1;
    while (index < B)
    {
        result = result * A;
        index++;
    }
    return result;
}
//-------------------------------------------------------------------------------------------------------------------------------
int A = Readint ("Введите число, которое хотите возвести в степень ");
int B = Readint ("Введите степень ");
if (B<0)
{
    System.Console.Write("Ошибка, введена отрицательная степень");
    return;
}
int result = Result (A, B);

System.Console.WriteLine(result);