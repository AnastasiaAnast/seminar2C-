﻿// Напишите программу, которая 
// на вход принимает натуральное число (N), а 
// на выходе показывает все четные числа от 1 до N (включительно)

Console.WriteLine("Введите любое число, чтобы увидеть все натуральные четные числа от 1 до этого числа включительно");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= num)
{
    Console.WriteLine($"{count} ");
    count = count + 2;
}
    if (count > num)
{
    Console.WriteLine("У данного числа нет натуральных четных числа от 1 до этого числа включительно");
}