/*
Задача итоговая. Написать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо равна 3 символа.
*/

Console.Clear();

string[] array = { "it", "is", "a", "great", "job", ":-))" };

void PrintStringArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

string[] GetNewStringArray(string[] array, int maxElementLength)
{
    int length = array.Length;
    string[] newArray = new string[length];
    int newIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxElementLength)
        {
            newArray[newIndex] = array[i];
            newIndex++;
        }
    }
    Array.Resize(ref newArray, newIndex);
    return newArray;
}

PrintStringArray(array);
string[] newArray = GetNewStringArray(array, 3);
PrintStringArray(newArray);
