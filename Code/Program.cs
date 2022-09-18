// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.

void CreateArray(string[] firstStringArray, string[] secondStringArray)
{
    int count = 0;
    for (int i = 0; i < firstStringArray.Length; i++)
    {
        if (firstStringArray[i].Length <= 3)
        {
            secondStringArray[count] = firstStringArray[i];
            count++;
        }
    }
}


void PrintArray(string[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.Write("]");
}


string[] firstStringArray = { "hello", "2", "world", ":-)" };
string[] secondStringArray = new string[firstStringArray.Length];

CreateArray(firstStringArray, secondStringArray);
PrintArray(secondStringArray);