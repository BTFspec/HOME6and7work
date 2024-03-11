// Рекурсия это вызов метода внутри метода.
//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


//   Console.Write("Введите цифру start: "); // подсказка
//  string? Strstart = Console.ReadLine(); // функция считывания строки 
// int start = int.Parse(Strstart);

// Console.Write("Введите цифру end: "); // подсказка
//  string? Strend = Console.ReadLine(); // функция считывания строки 
// int end = int.Parse(Strend);


//  void ShowNumbers (int start, int end)
//  {
// if (start == end) // рекурсия останавливается
// {
//     Console.WriteLine(start);
//     return; // в void return не совсем правильно писать он остановит всю программу и не выведет результат поэтому в переди вызываем Console.WriteLine
// }
// Console.Write(start + " "); // чтобы цифры шли с пробелом
// ShowNumbers(start+1, end); // сама рекурсия 
//  }

// ShowNumbers(start , end);   // 1 = int start;   7 = int end;






//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 3;
        int n = 2;
        int result = AckermannFunction(m, n);
        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}


//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// На основе символов строки (тип string) сформировать массив // ЗАДАЧА НАОБОРОТ 
// символов (тип char[]). Вывести массив на экран.

// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// char[] ConvertStringToCharArray(string str)           // ПИШЕМ char[] Т.К. ПОСЛЕ ФУНКЦИИ ХОТИМ ПОЛУЧИТЬ МАССИВ А ИСПОЛЬЗОВАТЬ БУДЕМ СТРОКУ  str
// {
//     char[] chars = new char[str.Length]; // Создаем массив chars и выделяем ему место [str.Length] столько элементов массива сколько букв в строке string str
//     // "hi" => [,], str.Length = 2, массив на 2 элемента
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i]; // 1й элемент массива равен пермому символу строки
//         //chars[0] = str[0], chars[0]=h
//         //chars[1] = str[1], chars[1]=i
//         // chars = ['h', 'i']
//     }
//     return chars;  // возвращаем заполненый массив chars строкой str
//     // str = "hi" => [h,i]
//     // "hi" => [str[0], str[1]]
// }
// // “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
// Console.Write("Введите строку: "); // подсказка
// string? str = Console.ReadLine(); // функция считывания строки 
// //string str = "Hello world";                     // НАША СТРОКА КОТОРУЮ ФУНКЦИЯ ConvertStringToCharArray БУДЕТ ВОЗВОДИТЬ В МАССИВ
// Console.WriteLine($"Строчка исходная: {str}");  // ВЫВОД СТРОКИ                                                                      // ТАК ВЫВОДЯТ СТРОКУ

// char[] chars = ConvertStringToCharArray(str);   // ВЫЗОВ ФУНКЦИИ ОНА БЕРЕТ СТРОКУ str И ОТДАЕТ МАССИВ chars
// Console.WriteLine($"Массив: [{string.Join("; ", chars)}]"); // ВЫВОД МАССИВЫ                                                        //ТАК ВЫВОДЯТ МАССИВ

// //int[] chars ={2,3,4,6,7};
// int j = chars.Length - 1;
// void PrintReverArray(char[] chars, int j)
// {
//     //int j = chars.Length - 1;
//    // int i = 0;
//     if (j < 0)//(j == 0)
//    // {
//         //Console.Write($"{chars[j]} ");
//         return;
//    // }
// Console.Write(chars[j] + " "); // чтобы цифры шли с пробелом
// PrintReverArray(chars, j - 1 ); // сама рекурсия 
// }

// PrintReverArray(chars,j);