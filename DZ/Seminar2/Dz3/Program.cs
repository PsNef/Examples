// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите день недели, код даст ответ - выходной он или нет (число от 1 до 7)");
int a = Convert.ToInt32(System.Console.ReadLine());

if (a > 7) 
{
    System.Console.WriteLine("Ошибка - введите число от 1 до 7");
}
else
{
    if (a > 5) System.Console.WriteLine("Да");
    else
    {
        System.Console.WriteLine("Нет");
    }
}

