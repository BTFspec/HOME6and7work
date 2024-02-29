// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:

// 1 Созданный массив готовый без функции

// using System.ComponentModel.DataAnnotations;

// int[,] matr = new int[,] {
//     {1, 2, 3},
//     {7, 8, 2},
//     {1, 1, 0},
//     {9, 10, 11}
// };

// 2 ФУНКЦИЯ ПЕЧАТЬ МАТРИЦЫ ДВУХМЕРНОГО МАССИВА

// void PrintMatrix(int[,] matr)  // ФУНКЦИЯ ВЫВОДА МАССИВА НА ЭКРАН КОТОРЫЙ МЫ СДЕЛАЛИ ВЫШЕ                       Цикл в цикле получается
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // стр  //попали в строчку обошли все столбцы; потом след строчка также
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // столбцы
//         {
//             Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела 
//         } // Закончили обход 0 строки, идем в 1
//         Console.WriteLine(); // Перенос на новую строчку \\ это чтобы каждая строка массива были раздельно а не на одной строке
//     }
// }

// 3 ФУНКЦИЯ которая будет находить cуммы строк

// int[] GetArrayWithMeans(int[,] array) 
// {                                                              
//     int[] sum = new int[array.GetLength(0)];
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           sum[i] += array[i,j];
//         }
//       }
//       return sum;
// }

// // 4 ФУНКЦИЯ КОТОРАЯ БУДЕТ НАХОДИТЬ ИНДЕКС СТРОКИ С МИНИМАЛЬНЫМИ ЗНАЧЕНИЯМИ
// int MinIndex(int[] array)
// {
//      int minI = 0;
//       for (int i =0; i < array.Length; i++)
//       {
//         if(array[minI] >array[i])
//         {
//           minI = i;
//         }
//       }
//     //   Console.WriteLine();
//       return minI;
// }

//                                                                   // 2 ФУНЦИЯ ВЫЗОВ

//     //PrintMatrix(matr); // это вызвали функцию печать массива; мы ее выше сделали так мы ее вызываем;


//                                                                          // 3 ФУНЦИЯ ВЫЗОВ

//  int[] res = GetArrayWithMeans(matr);
//                                                                               // 4 ФУНЦИЯ ВЫЗОВ                                                              
//  Console.WriteLine($"{MinIndex(res)}"); 




// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// // с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// // суммой элементов: 1 строка

// int Prompt(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int[,] CreateArray(int m, int n)
// {
//   int[,] array = new int[m, n];
//   return array;
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] FillArrayRandom(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1, 10);
//     }
//   }
//   return array;
// }

// int SumRowArray(int[,] array)
// {
//   int[] sumArr = new int[array.GetLength(0)];
//   Console.WriteLine($"Сумма по строке:");
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       sumArr[i] += array[i, j];
//     }
//     Console.WriteLine($"{i + 1} -> {sumArr[i]}");
//   }
//   int minSum = sumArr[0];
//   int minRow = 1;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     if (sumArr[i] < minSum)
//     {
//       minSum = sumArr[i];
//       minRow = i + 1;
//     }
//   }
//   return minRow;
// }

// int[,] array = CreateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));
// array = FillArrayRandom(array);
// PrintArray(array);
// int row = SumRowArray(array);
// Console.WriteLine($"Наименьшая сумма в {row} строке.");

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

// В коде, начальные условия:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int x = 2; // колонна
int y = 2; // ряд строка
//Выводится: 6;
bool ValidatePosition(int[,] numbers, int x, int y)
{

    if (y < 0 & y > numbers.GetLength(0))
    {
        Console.WriteLine("Позиция по рядам выходит за пределы массива");
    }
    if (x < 0 & x > numbers.GetLength(1))
    {
        Console.WriteLine("Позиция по колонкам выходит за пределы массива");
    }
    else
    {
        int element = numbers[x, y];
    }
}
int res = ValidatePosition(numbers);

void PrintResult(int[,] numbers, int x, int y)
{
Console.WriteLine(res);
}



