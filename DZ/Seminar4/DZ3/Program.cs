// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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
System.Console.WriteLine(String.Join(", ", array));