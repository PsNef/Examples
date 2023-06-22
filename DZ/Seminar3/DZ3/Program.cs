// 3 -> 1, 8, 27
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите чило");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int [a];
for (int i = 0; i < array.Length; i++)
{
    array[i] = (int)Math.Pow(i + 1, 3);
}
System.Console.WriteLine(String.Join(", ", array));
