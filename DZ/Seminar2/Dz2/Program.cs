// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите трехзначное число, или больше");
int a = Convert.ToInt32(System.Console.ReadLine());

if (a > 99)
{
    while (a > 999)
    {
        a = a / 10;
    }
    a = a % 10;
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
System.Console.WriteLine(a);

