﻿// Задача 16: Напишите программу, которая принимает на вход два числа
//  и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if ((number2 == number1*number1) || (number1 == number2*number2))
{
Console.WriteLine("одно из чисел является квадратом другого");    
}

else
{
   Console.WriteLine("ни одно из чисел не является квадратом другого"); 
}
