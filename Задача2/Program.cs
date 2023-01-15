/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int number = ReadInput("Введите число: ");
int length = Length(number);
Sum(number, length);

int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int Length(int arg)
{
    int index = 0;
    while (arg > 0)
    {
        arg /= 10;
        index++;
    }
    return index;
}


void Sum(int a, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += a % 10;
        a /= 10;
    }
    Console.WriteLine(sum);
}

