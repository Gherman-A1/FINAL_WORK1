﻿//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

void FillArray()
{
    Console.Write("Введите количество строк в массиве: ");
    int arrayLength=int.Parse(Console.ReadLine());
    string[] inputArray = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        inputArray[i] = Console.ReadLine();
    }
    Console.WriteLine("Введенный массив:");
    foreach (string element in inputArray)
    {
        Console.WriteLine(element);
    }
}

FillArray();