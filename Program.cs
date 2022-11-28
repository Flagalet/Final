// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] NewArray(string array)
{
    string[] count = array.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string[] res = new string[array.Length];
    for(int i = 0; i < count.Length; i++)
    {
        if(count.Length <= 3)
        {
            res[i] = count[i];
            return res;
        }
    }  
}

void PrintArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите Массив");
string input = Console.ReadLine();
string[] array = NewArray(input);
PrintArray(array);
