﻿// Создать двумерный массив с размерами
// 3 х 5, состоящий из целых чисел
// Вывести его элементы на экран
                                                                                                       // ЧАСТЬ 1
// int[,] matrix = new int [3,5]; // создаем двухмерный массив на 3 строки в каждой по 5 элементов;
// Random rnd = new Random(); // обьект Random создаст числа в трех массивах
//                                              // ЦИКЛ ПРОХОДА ПО  Массивам;
// for(int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength количество строк или кол-во массивов;
// {
//     for(int j = 0; j < matrix.GetLength(1); j++) // внутри цикла создадим второй цикл по проходу элементов массива;
//                                                  // j < matrix.GetLength(1) запросим количество столбцов в этом массиве;     
//     {
//         matrix[i,j] = rnd.Next(1, 11); // обьект Random создаст числа в трех массивах. в диапозоне от 1го до 11ти;
//     }
// }
//                                                                                                    // ЧАСТЬ 2
// for(int i = 0; i < matrix.GetLength(0); i++)   //проход по массивам;
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)  //проход по строкам массивов;
//     {
//         System.Console.Write($"{matrix[i,j]}, "); // такой вывод называется интерполяция строк; вывод массивов и их чисел
//     }
//     System.Console.WriteLine(); // делаем еще один вывод чтобы массивы были каждый в своей строке 
// }


// ЭТА ЖЕ ЗАДАЧА ТОЛЬКО В ВИДЕ ФУНЦИЙ                                                                   1 ФУНКИЯ

// вывод в виде функции (которая сформирует дввумерный массив из случайных целых чисел)
int [,] CreateMatrix (int rowCount, int colomsCount) // функция создания двухмерного массива колич столбцов и кол-во строк
{
int[,] matrix = new int[rowCount,colomsCount]; // выделим память на кол-во массивов и кол-во элементов массивов
Random rnd = new Random();
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = rnd.Next(1, 11);
    }
}
return matrix; // ВОЗВРАТ ГОТОВОГО МАССИВА


}                                                                                                             // 2  ФУНКИЯ
void ShowMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i,j]} "); // такой вывод называется интерполяция строк
    }
    System.Console.WriteLine();
}
}
int[,] matrix = CreateMatrix(4, 5); // ФУНКЦИЯ СОЗДАНИЯ ДВУХМЕРНОГО МАССИВА СЮДА ПИШЕМ КОЛ-ВО МАССИВОВ 1ЦИФРА
                                                                                    // И КОЛ-ВО СТРОК 2 ЦИФРА
ShowMatrix(matrix); // ФУНКЦИЯ ВЫВОДА ОТВЕТА В ТЕРМИНАЛ