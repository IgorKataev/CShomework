﻿// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// int a = 161;
// if (a % 7 == 0 && a % 23 == 0)
// {
//     Console.WriteLine($"Число {a} кратно 7 и 23");
// }
//     else
//     {
//       Console.WriteLine($"Число {a} не кратно 7 и 23");  
//     }

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка

// int x = 1;
// int y = -2;
// if (x > 0 && y > 0)
// {
//     Console.WriteLine($"Точка с координатами {x} : {y} находится в I четверти");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine($"Точка с координатами {x} : {y} находится во II четверти");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine($"Точка с координатами {x} : {y} находится в III четверти");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine($"Точка с координатами {x} : {y} находится в IV четверти");
// }

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа

// int number = 92;
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit >= secondDigit)
// {
//    Console.WriteLine($"{firstDigit}"); 
// }
// else
// {
//     Console.WriteLine($"{secondDigit}"); 
// }   

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую  

// int number = 6854972;
// string result = string.Format(" ");
// while (number > 0)
// {
//    int viewDigit = number % 10;
//    number = number /10;
//    result = viewDigit.ToString() + ", " + result;  
// }
// Console.Write(result);
