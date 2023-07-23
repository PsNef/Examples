// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string Readint (string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine()!;
}

int [] NewArray (string array)
{
    int [] array1 = new int [array.Length];
    int i = 0;
        while (i < array.Length)
    {
        array1[i] = Convert.ToInt32(array[i].ToString());
        i++;
    }
    return array1; 
}

//--------------------------------------------------------------------------------------------------------------------------
string A = Readint ("Введите массив");
int [] array = NewArray(A);
int i = 0;
int sum = 0;
while (i < A.Length)
{
    sum = sum + array[i];
    i++;
}

System.Console.WriteLine(sum);