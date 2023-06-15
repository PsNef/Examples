System.Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(System.Console.ReadLine());
int b = 0;
int  index = 0;
while (b < a)
{
    b = b + 1;
    if (b % 2 == 0) System.Console.Write(b+", ");
}