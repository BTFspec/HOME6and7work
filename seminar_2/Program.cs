﻿﻿// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

int number = 453; // ввели переменную number int цифровая переменнная.
int FirstDigit = number / 100;    // 453 /100 = 4 ввевели переменную где будет храниться первая цифра т.е. сотни "4ка" 
int ThirdDigit = number % 10; // 453 / 10% = 6 остаток получаем цифру 6.
int result = FirstDigit * 10 + ThirdDigit;  // 4 * 10 + 3 = 43
// $"Текст {result} текст {a+100} текст {a - 500}"
Console.WriteLine($"В числе {number} => {result}");

