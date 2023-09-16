//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] FillArray()
{
    Console.Write("Введите количество строк в массиве: ");
    int arrayLength=int.Parse(Console.ReadLine());
    string[] inputArray = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        inputArray[i] = Console.ReadLine();
    }
    return inputArray;
}

void PrintArray(string[]array)
{
    Console.WriteLine("массив:");
    foreach (string element in array)
    {
        Console.WriteLine(element);
    }
}

string[] FilterStringsByLength(string[] inputArray, int maxLength)
{
    return inputArray.Where(element => element.Length <= maxLength).ToArray();
}

string[] userArray=FillArray();
PrintArray(userArray);
string[] resultArray=FilterStringsByLength(userArray,3);
Console.WriteLine("Получен новый массив из строк, длина которых меньше, либо равна 3 символам");
PrintArray(resultArray);