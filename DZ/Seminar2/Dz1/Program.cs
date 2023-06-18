// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(System.Console.ReadLine());

if (a < 1000 && a > -1000)
{
    a = a / 10;
    a = a % 10 * -1;
}
else
{
    System.Console.WriteLine("Ошибка - введено не трехзначное число");
}
System.Console.WriteLine(a);