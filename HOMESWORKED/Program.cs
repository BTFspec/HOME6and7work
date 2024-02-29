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




int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int x = 2;
int y = 2;
//Выводится: 6
static bool ValidatePosition(int[,] array, int x, int y)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    bool rtdp = true;
    if (x <= 0 && x > array.GetLength(0)) 
{
  Console.WriteLine("Позиция по рядам выходит за пределы массива");
}
    if (y <= 0 && y > array.GetLength(1))
    {
Console.WriteLine("Позиция по колонкам выходит за пределы массива");
    }
    else 
    {
        
    }
    return rtdp;
}
 bool с = ValidatePosition( numbers,  x,  y);
 Console.WriteLine(с);
 
// Верните элемент из массива по позиции
// Подсказка № 1
// Напишите функцию, проверяющую, что позиции входят в границы массива.

// Подсказка № 2
// Напишите функцию, которая ищет элемент по пощициям внутри массива.

// Подсказка № 3
// Циклы не нужны, достаточно от позиции отнять 1, это будет индексом.

// Подсказка № 4
// Вызовите функцию проверки позиций в массиве

// Подсказка № 5
// Если проверка сработала, вызовите функцию поиска элемента.