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
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum[i] += array[i, j];
//         }
//     }
//     return sum;
// }

// // 4 ФУНКЦИЯ КОТОРАЯ БУДЕТ НАХОДИТЬ ИНДЕКС СТРОКИ С МИНИМАЛЬНЫМИ ЗНАЧЕНИЯМИ
// int MinIndex(int[] array)
// {
//     int minI = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[minI] > array[i])
//         {
//             minI = i;
//         }
//     }
//     //   Console.WriteLine();
//     return minI;
// }

// 2 ФУНЦИЯ ВЫЗОВ

//PrintMatrix(matr); // это вызвали функцию печать массива; мы ее выше сделали так мы ее вызываем;


// 3 ФУНЦИЯ ВЫЗОВ

// int[] res = GetArrayWithMeans(matr);
// // 4 ФУНЦИЯ ВЫЗОВ                                                              
// Console.WriteLine($"{MinIndex(res)}");

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

// В коде, начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 3;
// int y = 4;
// //Выводится: 6
// static bool ValidatePosition(int[,] array, int x, int y)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);
//     bool rtdp = true;

//     if (x < 0 || x > rows)
//     {
//         Console.WriteLine($"Позиция по рядам выходит за пределы массива");
//         return false;
//     }

//     else if (y < 0 || y > columns)
//     {
//         Console.WriteLine($"Позиция по колонкам выходит за пределы массива");
//     }
//     if (x >= 0 && x <= rows && y >= 0 && y <= columns)
//     {
//         int element = array[x - 1, y - 1];
//         Console.WriteLine(element);

//     }
//     return rtdp;
// }
// ValidatePosition(numbers, x, y);


// Верните элемент из массива по позиции.
// Подсказка № 1.
// Напишите функцию, проверяющую, что позиции входят в границы массива.

// Подсказка № 2.
// Напишите функцию, которая ищет элемент по пощициям внутри массива.

// Подсказка № 3.
// Циклы не нужны, достаточно от позиции отнять 1, это будет индексом.

// Подсказка № 4.
// Вызовите функцию проверки позиций в массиве.

// Подсказка № 5.
// Если проверка сработала, вызовите функцию поиска элемента.




//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] array = new int[,]
          {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
          };
int x = 2;
int y = 2;

// Поиск элемента по позициям

static int FindElementByPosition(int[,] array, int x, int y)

{
    int element = array[x - 1, y - 1];
    return element;
}

// Проверка позиций на вхождение в массив
static bool ValidatePosition(int[,] array, int x, int y)
{
   // int rows = array.GetLength(0);
    //int columns = array.GetLength(1);
    if (x < 0 || x > array.GetLength(0))
    {
        Console.WriteLine($"Позиция по рядам выходит за пределы массива");
        return false;
    }
    else if (y < 0 || y > array.GetLength(0))
    {
        Console.WriteLine($"Позиция по колонкам выходит за пределы массива");
        return false;
    }
    return true;
}

static void PrintResult(int[,] numbers, int x, int y)
{
    // int rows = numbers.GetLength(0);
    // int columns = numbers.GetLength(1);
    if (x >= 0 && x <= numbers.GetLength(0) && y >= 0 && y <= numbers.GetLength(1))
    {
        int element = numbers[x - 1, y - 1];
        Console.WriteLine(element);
    }
}

// 2 функция вызов
ValidatePosition(array, x, y);

// 1 функция вызов
FindElementByPosition(array, x, y);

// 3 функция вызов
PrintResult(array, x, y);

//Задача 3
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Начальные условия:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 
// Выводится:

// 9   10  11  12
// 5   6   7   8
// 1   2   3   4

 // Печать массива
     static void PrintArray(int[,] array)
    {

    }


    // Обмен первой с последней строкой
     static int[,] SwapFirstLastRows(int[,] array)
    {
      
    }


    // Обмен элементами массива
     static void SwapItems(int[,] array, int i)
    {
       

    }

    
      static void PrintResult(int[,] numbers)
    {
        //Напишите свое решение здесь
    }