/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */





void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}

Console.WriteLine("Введи длину массива: ");
int lenArray = int.Parse(Console.ReadLine());
int[] array = new int[lenArray];
FillArray(array);
PrintArray(array);
Console.Write($" -> [ {String.Join(", ", array)} ] ");
