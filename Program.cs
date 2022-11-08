﻿// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
Console.Write("Введите размер массива из строк: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] arrayString = new string [size];
Console.WriteLine("Введите строки в массиве: ");
for (int i = 0; i < size; i++)
{
    arrayString [i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine ("Решение задачи первым методом: используя возможности языка С#");
PrintArrayString (arrayString);
Console.Write (" -> ");
string[] group = Array.FindAll(arrayString, str => str.Length <= 3);
if (group.Length > 0) PrintArrayString (group);
else Console.Write ("[]");

Console.WriteLine();
Console.WriteLine ("Решение задачи вторым методом");
PrintArrayString (arrayString);
Console.Write (" -> ");
int count = SizeSortedArrayString (arrayString);
if (count > 0) 
{
    string [] sortArr = SortedArrayString (arrayString, count);
    PrintArrayString (sortArr);
}
else Console.Write ("[]");

string [] SortedArrayString (string [] arrayString, int count)
{
    string [] sortedArray = new string [count];
    int j = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= 3)
        {
           sortedArray [j] = arrayString [i];
           j++;
        }
    }
    return sortedArray;
}

int SizeSortedArrayString (string [] arrayString)
{
    int count = default;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= 3)
        {
           count++;
        }
    }
    return count;
}

void PrintArrayString (string [] arrStr)
{
    Console.Write ("[");
    for (int i = 0; i < arrStr.Length-1; i++)
    {
        Console.Write ($"\"{arrStr[i]}\", ");
    }
    Console.Write ($"\"{arrStr[arrStr.Length-1]}\"");
    Console.Write ("]");
}