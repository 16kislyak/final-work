// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] GetArray(int size)
{
    string[] res = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        res[i] = (Console.ReadLine()!).ToString();
    }
    return res;
}

Console.Write("Введите количество элементов массива: ");
int M = int.Parse(Console.ReadLine()!);
string[] newArray = GetArray(M);
Console.Write("[");
Console.Write(String.Join(", ", newArray));
Console.WriteLine("]");