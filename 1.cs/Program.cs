﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Ваше трёхзначное число: ");

string stringNumber = Convert.ToString(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("вторая цифра этого числа - "+stringNumber[1]);


