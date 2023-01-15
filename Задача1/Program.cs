

/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */


Console.WriteLine("Введи число А: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число В: ");
int B = int.Parse(Console.ReadLine());
double product = A;
if (B == 0) product = 1;
for (int i = 1; i < B; i++)
{
    product = product * A;
}

Console.WriteLine($"{A}, {B} -> {product}");