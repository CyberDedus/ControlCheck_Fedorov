﻿void Print(string [] arr)

{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }   
    Console.WriteLine();
}

Console.WriteLine("Введите числа или слова через пробел: ");
string line = Console.ReadLine();
string[] arr1 = line.Split(' ');
string[] arr2 = new string [arr1.Length];
int count = 0;