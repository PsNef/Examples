// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.WriteLine("Введите пятизначное число");
string a = System.Console.ReadLine()!;
if (a.Length == 5)
{
    if (a [0] == a [4] && a [1] == a [3])
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}
else
{
    System.Console.WriteLine("Ошбка - введено не 5ти значное число!");
}