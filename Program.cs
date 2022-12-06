// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] GetArray(int size)
{
    string[] res = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        res[i] = (Console.ReadLine()!).ToString();
    }
    return res;
}

string[] ArrayThreeSymbol(string[] sourceArr)
{
    int leng = 0;
    for (int i = 0; i < sourceArr.Length; i++)
    {
        if ((sourceArr[i].Length) <= 3)
        {
            leng++;
        }
    }
    string[] finArray = new string[leng];
    int count = 0;
    for (int k = 0; k < sourceArr.Length; k++)
    {
        if ((sourceArr[k].Length) <= 3)
        {
            finArray[count] = sourceArr[k];
            count++;
        }
    }
    return finArray;
}

Console.Write("Введите количество элементов массива: ");
int M = int.Parse(Console.ReadLine()!);
string[] Array = GetArray(M);
Console.Write("[");
Console.Write(String.Join(", ", Array));
Console.WriteLine("]");

string[] newArray = ArrayThreeSymbol(Array);
Console.Write("[");
Console.Write(String.Join(", ", newArray));
Console.WriteLine("]");