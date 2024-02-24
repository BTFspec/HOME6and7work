// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

// ФУНКЦИЯ СОЗДАНИЯ МАТРИЦЫ ДВУХМЕРНОГО МАССИВА
int[,] CreateMatrix(int rows, int columns) //int[,] запятая показывпет что массив двумерный; функция с двумя переменными;
{
    int[,] matr = new int[rows, columns]; // [строки, столбцы]
    Random rnd = new Random(); // в переменной rnd лежит наш рандомный массив
    for (int i = 0; i < rows; i++) // rows = matr.GetLength(0) 0 это индекс строки; rows обращается к длине нашей строки
    {                               //columns = matr.GetLength(1) 1 это индекс столбцов
        // j, m, k
        for (int j = 0; j < columns; j++) // columns = matr.GetLength(1) // перебор столбца
        {
            matr[i, j] = rnd.Next(101); // [0,100], (0, 101) 
        }
    }
    return matr; // возвращаем готовый массив созданный от 0 до 100
}

void PrintMatrix(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++) // стр
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела 
        } // Закончили обход 0 строки, идем в 1
        Console.WriteLine(); // Перенос на новую строчку
    }
}